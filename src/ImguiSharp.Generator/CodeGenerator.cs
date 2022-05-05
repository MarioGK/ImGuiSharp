using ImGuiSharp.Generator.Data;
using ImGuiSharp.Generator.Models;
using Scriban;

namespace ImGuiSharp.Generator;

public class CodeGenerator
{
    public CodeGenerator(ProjectInfo projectInfo)
    {
        DefinitionsParser = new DefinitionsParser(projectInfo);
    }

    public DefinitionsParser DefinitionsParser { get; set; }

    public IEnumerable<GeneratedFile> Generate()
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
        return DefinitionsParser.StructDefinitions.Select(x => ParseWithTemplate("Struct.template", x));
    }

    private static GeneratedFile ParseWithTemplate(string templateName, BaseDefinition data)
    {
        var templateString = ResourceReader.GetResource(templateName);
        var template = Template.Parse(templateString);
        var code = template.Render(data, member => member.Name);

        if (string.IsNullOrEmpty(code))
        {
            throw new Exception($"Code could not be generated for {data.Name}");
        }
        
        return new GeneratedFile(data.Name + ".gen.cs", code);
    }
}