using System.Text;
using ImGuiSharp.Generator.Data;
using ImGuiSharp.Generator.Enumeration;
using ImGuiSharp.Generator.Models;
using Scriban;

namespace ImGuiSharp.Generator;

public class CodeGenerator
{
    private readonly ProjectInfo _projectInfo;

    public CodeGenerator(ProjectInfo projectInfo)
    {
        DefinitionsParser = new DefinitionsParser(projectInfo);
        _projectInfo = projectInfo;
    }

    public DefinitionsParser DefinitionsParser { get; set; }

    public IEnumerable<GeneratedFile> Generate()
    {
        DefinitionsParser.ParseAll();
        var structs = GenerateStructs();
        //var enums = GenerateEnums();

        return structs; //.Concat(enums);
    }

    private IEnumerable<GeneratedFile> GenerateEnums()
    {
        var structTemplate = new OldTemplate(TemplateType.Struct);
        var fieldTemplate = new OldTemplate(TemplateType.Field);
        foreach (var structDefinition in DefinitionsParser.StructDefinitions)
        {
            var structCode = structTemplate.Copy();
            structCode.Set("NAMESPACE", _projectInfo.NameSpace);
            structCode.Set("STRUCT_NAME", structDefinition.Name);

            var fields = new StringBuilder();

            foreach (var field in structDefinition.Fields)
            {
                field.CleanType();
                var fieldCode = fieldTemplate.Copy();

                //Convert C++ type to C# type
                var managedType = TypeInfo.Types.FirstOrDefault(t => t.Key == field.Type);

                //If no managed type, use the default type
                fieldCode.Set("TYPE", managedType.Key == null ? field.Type : managedType.Value);
                fieldCode.Set("FIELD_NAME", field.FriendlyName);
                fieldCode.CleanUnused();
                fields.Append(fieldCode);
            }

            structCode.Set("CONTENT", fields.ToString());
            structCode.CleanUnused();

            yield return new GeneratedFile(structDefinition.Name + ".gen.cs", structCode.ToString());
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