using System.Text;
using ImGuiSharp.Generator.Enumeration;
using ImGuiSharp.Generator.Models;

namespace ImGuiSharp.Generator;

public class Generator
{
    public Generator(ProjectInfo projectInfo, string output)
    {
        Output = output;
        Parser = new Parser(projectInfo);
        _projectInfo = projectInfo;
    }

    public Parser Parser { get; set; }
    public string Output { get; set; }

    private ProjectInfo _projectInfo;

    public void Generate()
    {
        Parser.ParseAll();
        GenerateStructs();
    }

    public void GenerateStructs()
    {
        var structTemplate = new Template(TemplateType.Struct);
        var fieldTemplate  = new Template(TemplateType.Field);
        foreach (var structDefinition in Parser.StructDefinitions)
        {
            var structCode = structTemplate.Copy();
            structCode.Set("NAMESPACE",   _projectInfo.ManagedProjectName);
            structCode.Set("STRUCT_NAME", structDefinition.Name);

            var fields = new StringBuilder();

            foreach (var field in structDefinition.Fields)
            {
                var fieldCode = fieldTemplate.Copy();
                fieldCode.Set("TYPE", field.Type);
                fieldCode.Set("FIELD_NAME", field.Name);
                fieldCode.CleanUnused();
                fields.Append(fieldCode);
            }
            
            structCode.Set("CONTENT", fields.ToString());
            structCode.CleanUnused();
        }
    }
}