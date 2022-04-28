using System.Text.Json;
using System.Text.Json.Nodes;
using ImguiSharp.Generator.Data;
using ImguiSharp.Generator.Models;

namespace ImguiSharp.Generator;

public class Parser
{
    public ProjectInfo ProjInfo       { get; set; }
    public string      DefinitionsDirectory { get; }
    
    public List<VariantDefinition>  VariantDefinitions  { get; } = new();
    public List<EnumDefinition>     EnumDefinitions     { get; } = new();
    public List<StructDefinition>   StructDefinitions   { get; } = new();
    public List<FunctionDefinition> FunctionDefinitions { get; } = new();
    public List<FunctionDefinition> ImplementedDefinitions { get; } = new();

    public Parser(ProjectInfo projInfo)
    {
        ProjInfo             = projInfo;
        DefinitionsDirectory = Path.Combine(AppContext.BaseDirectory, "defs", projInfo.NativeProjectName);
    }
    
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
        var content = ReadFile("impl_definitions.json");

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
        var content = ReadFile("definitions.json");

        if (string.IsNullOrEmpty(content))
        {
            return; 
        }

        var document     = JsonDocument.Parse(content);

        foreach (var enumProp in document.RootElement.EnumerateObject())
        {
            var id       = enumProp.Name;
            
            
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
        var content = ReadFile("structs_and_enums.json");

        if (string.IsNullOrEmpty(content))
        {
            return; 
        }

        var document     = JsonDocument.Parse(content);
        var enumsElement = document.RootElement.GetProperty("enums");
        var locations    = document.RootElement.GetProperty("locations");
        
        foreach (var enumProp in enumsElement.EnumerateObject())
        {
            var id       = enumProp.Name;
            var location = locations.GetProperty(id).GetString()!;
            
            var enumDef = new EnumDefinition
            {
                Id = id,
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
        var content = ReadFile("structs_and_enums.json");

        if (string.IsNullOrEmpty(content))
        {
            return; 
        }

        var document     = JsonDocument.Parse(content);
        var structsElement = document.RootElement.GetProperty("structs");
        var locations    = document.RootElement.GetProperty("locations");
        
        foreach (var structProp in structsElement.EnumerateObject())
        {
            var id       = structProp.Name;
            var location = locations.GetProperty(id).GetString()!;

            var structDefinition = new StructDefinition
            {
                Name = id,
                Location = location
            };

            foreach (var innerProp in structProp.Value.EnumerateArray())
            {
                var fieldDefinition = innerProp.Deserialize<StructField>();

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
}