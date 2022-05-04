using System.Text.Json;
using ImGuiSharp.Generator.Data;
using ImGuiSharp.Generator.Models;

namespace ImGuiSharp.Generator;

public class DefinitionsParser
{
    public DefinitionsParser(ProjectInfo projInfo)
    {
        ProjInfo = projInfo;
    }

    public ProjectInfo ProjInfo { get; set; }

    public List<VariantDefinition> VariantDefinitions { get; } = new();
    public List<EnumDefinition> EnumDefinitions { get; } = new();
    public List<StructDefinition> StructDefinitions { get; } = new();
    public List<FunctionDefinition> FunctionDefinitions { get; } = new();
    public List<FunctionDefinition> ImplementedDefinitions { get; } = new();

    public void ParseAll()
    {
        ParseVariants();
        ParseEnums();
        ParseStructs();
        ParseDefinitions();
        ParseImplementedDefinitions();
    }

    public void ParseImplementedDefinitions()
    {
        var content = GetFileContent("impl_definitions.json");

        if (string.IsNullOrEmpty(content))
        {
            return;
        }

        var document = JsonDocument.Parse(content);

        foreach (var enumProp in document.RootElement.EnumerateObject())
        {
            var id = enumProp.Name;

            foreach (var innerProp in enumProp.Value.EnumerateArray())
            {
                var functionDefinition = innerProp.Deserialize<FunctionDefinition>();

                if (functionDefinition == null)
                {
                    continue;
                }

                functionDefinition.Id = id;
                ImplementedDefinitions.Add(functionDefinition);
            }
        }
    }

    public void ParseDefinitions()
    {
        var content = GetFileContent("definitions.json");

        if (string.IsNullOrEmpty(content))
        {
            return;
        }

        var document = JsonDocument.Parse(content);

        foreach (var enumProp in document.RootElement.EnumerateObject())
        {
            var id = enumProp.Name;


            foreach (var innerProp in enumProp.Value.EnumerateArray())
            {
                var functionDefinition = innerProp.Deserialize<FunctionDefinition>();

                if (functionDefinition == null)
                {
                    continue;
                }

                functionDefinition.Id = id;
                FunctionDefinitions.Add(functionDefinition);
            }
        }
    }

    public void ParseEnums()
    {
        var content = GetFileContent("structs_and_enums.json");

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

            EnumDefinitions.Add(enumDef);
        }
    }

    public void ParseStructs()
    {
        var content = GetFileContent("structs_and_enums.json");

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

                if (fieldDefinition != null)
                {
                    structDefinition.Fields.Add(fieldDefinition);
                }
            }

            StructDefinitions.Add(structDefinition);
        }
    }

    public void ParseVariants()
    {
        var content = GetFileContent("variants.json");

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

    private string GetFileContent(string file)
    {
        return ResourceReader.GetResource($"{ProjInfo.NativeProjectName}.{file}") ?? string.Empty;
    }
}