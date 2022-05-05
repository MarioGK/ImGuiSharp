using ImGuiSharp.Generator.Data;
using ImGuiSharp.Generator.Helpers;
using ImGuiSharp.Generator.Models;
using Scriban;

namespace ImGuiSharp.Generator;

internal class CodeGenerator
{
    public CodeGenerator(ProjectInfo projectInfo)
    {
        DefinitionsParser = new DefinitionsParser(projectInfo);
    }

    public DefinitionsParser DefinitionsParser { get; set; }

    public IEnumerable<GeneratedFile> GenerateAll()
    {
        DefinitionsParser.ParseAll();

        var structs = GenerateStructs();
        var enums = GenerateEnums();

        return structs.Concat(enums);
    }

    private IEnumerable<GeneratedFile> GeneratedClasses()
    {
        yield return new GeneratedFile("","");
    }

    private IEnumerable<GeneratedFile> GenerateEnums()
    {
        return DefinitionsParser.EnumDefinitions.Select(x => ParseWithTemplate("Enum.template", x));
    }

    private IEnumerable<GeneratedFile> GenerateStructs()
    {
        return DefinitionsParser.StructDefinitions
                                .Where(x => !TypeInfo.CustomDefinedTypes.Contains(x.Name))
                                .Where(x => !TypeInfo.IgnoredEnums.Contains(x.Name))
                                .Select(x => ParseWithTemplate("Struct.template", x));
    }

    private static GeneratedFile ParseWithTemplate(string templateName, BaseDefinition data)
    {
        var templateString = ResourceReader.GetResource(templateName);
        var template = Template.Parse(templateString);
        var code = template.Render(data, member => member.Name);
        code = code.RemoveEmptyLines();

        if (string.IsNullOrEmpty(code))
        {
            throw new Exception($"Code could not be generated for {data.FriendlyName}");
        }
        
        return new GeneratedFile(data.FriendlyName + ".gen.cs", code);
    }
}