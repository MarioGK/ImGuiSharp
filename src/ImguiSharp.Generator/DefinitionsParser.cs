using System.Text.Json;
using ImGuiSharp.Generator.Data;
using ImGuiSharp.Generator.Helpers;
using ImGuiSharp.Generator.Models;

namespace ImGuiSharp.Generator;

/// <summary>
/// The purpose of this class is to parse the definition files and clean up the data and if needed convert it.
/// </summary>
internal class DefinitionsParser
{
    public DefinitionsParser(ProjectInfo projInfo)
    {
        ProjInfo = projInfo;
        DefinitionsDirectory = Path.Combine(AppContext.BaseDirectory, "defs", projInfo.NativeProjectName);
    }

    public string      DefinitionsDirectory { get; }
    public ProjectInfo ProjInfo { get; set; }

    public List<VariantDefinition> VariantDefinitions { get; } = new();
    public List<EnumDefinition> EnumDefinitions { get; } = new();
    public List<StructDefinition> StructDefinitions { get; } = new();
    public List<FunctionDefinition> FunctionDefinitions { get; } = new();

    public void ParseAll()
    {
        ParseVariants();
        ParseEnums();
        ParseStructs();
        ParseDefinitions();
    }

    public void ParseDefinitions()
    {
        var definitionsContent = ReadFile("definitions.json");
        var implDefinitionContent = ReadFile("impl_definitions.json");

        var definitionsDocument = JsonDocument.Parse(definitionsContent);
        var implDefinitionDocument = JsonDocument.Parse(implDefinitionContent);

        var objects = definitionsDocument.RootElement.EnumerateObject()
                                          .Concat(implDefinitionDocument.RootElement.EnumerateObject());

        foreach (var enumProp in objects)
        {
            var id = enumProp.Name;

            foreach (var innerProp in enumProp.Value.EnumerateArray())
            {
                var functionOverload = innerProp.Deserialize<FunctionDefinition>();

                if (functionOverload == null || 
                    functionOverload.Cimguiname.EndsWith("nonUDT") ||
                    functionOverload.ExportedName.Contains('~'))
                {
                    continue;
                }
                
                if (functionOverload.ArgumentDefinitions.Any(tr => tr.Type.Contains('(')))
                {
                    continue;
                } // TODO: Parse function pointer parameters.

                functionOverload.RunFixes();
                functionOverload.Id = id;

                if (string.IsNullOrEmpty(functionOverload.ReturnType) || functionOverload.ExportedName.ContainsAny(TypeInfo.FunctionsToIgnore))
                {
                    continue;
                }

                FunctionDefinitions.Add(functionOverload);
            }
        }
    }

    public void ParseEnums()
    {
        var content = ReadFile("structs_and_enums.json");

        if (string.IsNullOrEmpty(content))
        {
            return;
        }

        var document = JsonDocument.Parse(content);
        var enumsElement = document.RootElement.GetProperty("enums");
        var locations = document.RootElement.GetProperty("locations");

        foreach (var enumProp in enumsElement.EnumerateObject())
        {
            var id = enumProp.Name;
            if (id.Contains("Private"))
            {
                continue;
            }
            
            var location = locations.GetProperty(id).GetString()!;

            var enumDef = new EnumDefinition
            {
                Name = id,
                Location = location
            };

            foreach (var innerProp in enumProp.Value.EnumerateArray())
            {
                var enumValue = innerProp.Deserialize<EnumValue>();

                if (enumValue != null)
                {
                    enumDef.Values.Add(enumValue);
                }
            }

            //Sanitize the names and values
            enumDef.FixSize();
            enumDef.NameSpace = ProjInfo.NameSpace;
            enumDef.SanitizeNames();

            EnumDefinitions.Add(enumDef);
        }
    }

    public void ParseStructs()
    {
        var content = ReadFile("structs_and_enums.json");

        if (string.IsNullOrEmpty(content))
        {
            return;
        }

        var document = JsonDocument.Parse(content);
        var structsElement = document.RootElement.GetProperty("structs");
        var locations = document.RootElement.GetProperty("locations");

        foreach (var structProp in structsElement.EnumerateObject())
        {
            var id = structProp.Name;
            var location = locations.GetProperty(id).GetString()!;

            var structDefinition = new StructDefinition
            {
                Name = id,
                Location = location,
                NameSpace = ProjInfo.NameSpace
            };

            foreach (var innerProp in structProp.Value.EnumerateArray())
            {
                var fieldDefinition = innerProp.Deserialize<TypeDefinition>();

                if (fieldDefinition == null || fieldDefinition.Type.Contains("union"))
                {
                    continue;
                }

                fieldDefinition = FixSize(fieldDefinition);

                fieldDefinition.IsEnum = EnumDefinitions.Any(enumDefinition =>
                                                                 enumDefinition.Name         == fieldDefinition.Type ||
                                                                 enumDefinition.FriendlyName == fieldDefinition.Type ||
                                                                 TypeInfo.WellKnownEnums
                                                                         .Contains(fieldDefinition.Type));
                fieldDefinition.CleanType();
                structDefinition.Fields.Add(fieldDefinition);
            }

            StructDefinitions.Add(structDefinition);
        }
    }

    public void ParseVariants()
    {
        var content = ReadFile("variants.json");

        if (string.IsNullOrEmpty(content))
        {
            return;
        }

        var variantsDocument = JsonDocument.Parse(content);

        foreach (var property in variantsDocument.RootElement.EnumerateObject())
        {
            var id = property.Name;
            foreach (var variant in property.Value.EnumerateArray())
            {
                var variantDef = variant.Deserialize<VariantDefinition>();
                if (variantDef == null)
                {
                    continue;
                }

                variantDef.Id = id;

                VariantDefinitions.Add(variantDef);
            }
        }
    }
    
    private string ReadFile(string file)
    {
        file = Path.Combine(DefinitionsDirectory, file);
        return !File.Exists(file) ? string.Empty : File.ReadAllText(file);
    }

    private TypeDefinition FixSize(TypeDefinition typeDefinition)
    {
        var startBracket = typeDefinition.Name.IndexOf('[');
        
        if (startBracket == -1)
        {
            return typeDefinition;
        }

        //This is only for older cimgui binding jsons
        var endBracket = typeDefinition.Name.IndexOf(']');
        var sizePart = typeDefinition.Name.Substring(startBracket + 1, endBracket - startBracket - 1);
        if (typeDefinition.ArraySize == 0)
        {
            var plusStart = sizePart.IndexOf('+');
            if (plusStart != -1)
            {
                var first = sizePart[..plusStart];
                var second = sizePart.Substring(plusStart, sizePart.Length - plusStart);
                var firstVal = int.Parse(first);
                var secondVal = int.Parse(second);
                typeDefinition.ArraySize = firstVal + secondVal;
            }

            if (int.TryParse(sizePart, out var ret))
            {
                typeDefinition.ArraySize = ret;
            }

            foreach (var ed in EnumDefinitions)
            {
                if (!sizePart.StartsWith(ed.Name))
                {
                    continue;
                }

                foreach (var member in ed.Values)
                {
                    if (member.Name == sizePart)
                    {
                        typeDefinition.ArraySize = int.Parse(member.Value);
                    }
                }
            }
            //TODO is this needed?
            //ret = -1;

            //return ret;
        }

        typeDefinition.Name = typeDefinition.Name[..startBracket];
        return typeDefinition;
    }
}