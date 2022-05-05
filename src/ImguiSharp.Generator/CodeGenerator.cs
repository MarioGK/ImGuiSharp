using ImGuiSharp.Generator.Data;
using ImGuiSharp.Generator.Helpers;
using ImGuiSharp.Generator.Models;
using Scriban;

namespace ImGuiSharp.Generator;

internal class CodeGenerator
{
    public string Output { get; }
    public CodeGenerator(ProjectInfo projectInfo, string output)
    {
        Output = output;
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

    public void WriteAll()
    {
        var files = GenerateAll();
        WriteFiles(files);
    }

    private IEnumerable<GeneratedFile> GeneratedClasses()
    {
        yield return new GeneratedFile("", "");
    }

    private IEnumerable<GeneratedFile> GenerateEnums()
    {
        return DefinitionsParser.EnumDefinitions.Select(x => ParseWithTemplate("Enum.template", x));
    }

    private IEnumerable<GeneratedFile> GenerateStructs()
    {
        return DefinitionsParser.StructDefinitions
                                .Where(x => !TypeInfo.CustomDefinedTypes.Contains(x.Name) &&
                                            !TypeInfo.IgnoredEnums.Contains(x.Name))
                                .Select(x => ParseWithTemplate("Struct.template", x));
    }

    private static GeneratedFile ParseWithTemplate(string templateName, BaseDefinition data)
    {
        var templateString = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Templates", templateName));
        var template = Template.Parse(templateString);
        var code = template.Render(data, member => member.Name);
        code = code.RemoveEmptyLines();

        if (string.IsNullOrEmpty(code))
        {
            throw new Exception($"Code could not be generated for {data.FriendlyName}");
        }

        return new GeneratedFile(data.FriendlyName + ".gen.cs", code);
    }

    private void WriteFiles(IEnumerable<GeneratedFile> files)
    {
        if (Directory.Exists(Output))
        {
            Directory.Delete(Output, true);
            Directory.CreateDirectory(Output);
        }
        else
        {
            Directory.CreateDirectory(Output);
        }
        
        foreach (var file in files)
        {
            var path = Path.Combine(Output, file.FileName);
            Console.WriteLine($"Writing file: {path}");
            File.WriteAllText(path, file.Content);
        }
    }
}