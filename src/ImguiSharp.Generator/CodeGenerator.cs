using System.Text;
using ImGuiSharp.Generator.Data;
using ImGuiSharp.Generator.Enumeration;
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
        foreach (var structDefinition in DefinitionsParser.EnumDefinitions)
        {
            var structTemplateString = ResourceReader.GetResource("Enum.template");
            var structTemplate = Template.Parse(structTemplateString);
            var structCode = structTemplate.Render(structDefinition, member => member.Name);
            yield return new GeneratedFile(structDefinition.Name + ".gen.cs", structCode);
        }
    }

    private IEnumerable<GeneratedFile> GenerateStructs()
    {
        //var structTemplate = new Template(TemplateType.Struct);

        foreach (var structDefinition in DefinitionsParser.StructDefinitions)
        {
            var structTemplateString = ResourceReader.GetResource("Struct.template");
            var structTemplate = Template.Parse(structTemplateString);
            var structCode = structTemplate.Render(structDefinition, member => member.Name);
            yield return new GeneratedFile(structDefinition.Name + ".gen.cs", structCode);
        }
    }
}