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
                field.CleanType();
                var fieldCode = fieldTemplate.Copy();
                
                //Convert C++ type to C# type
                var managedType = TypeInfo.Types.FirstOrDefault(t => t.Key == field.Type);

                //If no managed type, use the default type
                fieldCode.Set("TYPE",       managedType.Key == null ? field.Type : managedType.Value);
                fieldCode.Set("FIELD_NAME", field.FriendlyName);
                fieldCode.CleanUnused();
                fields.Append(fieldCode);
            }
            
            structCode.Set("CONTENT", fields.ToString());
            structCode.CleanUnused();
            
            Write(structDefinition.Name + ".gen.cs", structCode.ToString());
        }
    }

    private void Write(string fileName, string content)
    {
        var path = Path.Combine(Output, fileName);
        if(!Directory.Exists(Output))
        {
            Directory.CreateDirectory(Output);
        }

        File.WriteAllText(path, content);
    }
}