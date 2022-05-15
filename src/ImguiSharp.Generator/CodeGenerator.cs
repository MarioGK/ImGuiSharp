using ImGuiSharp.Generator.Data;
using ImGuiSharp.Generator.Helpers;
using ImGuiSharp.Generator.Models;
using Scriban;
using Scriban.Runtime;

namespace ImGuiSharp.Generator;

internal class CodeGenerator
{
    private readonly ProjectInfo _projectInfo;
    public string Output { get; }
    public CodeGenerator(ProjectInfo projectInfo, string output)
    {
        _projectInfo = projectInfo;
        Output = output;
        DefinitionsParser = new DefinitionsParser(projectInfo);
        _templateContext = new TemplateContext
        {
            LoopLimit = 0,
            MemberRenamer = member => member.Name
        };
    }
    private readonly TemplateContext _templateContext;

    public DefinitionsParser DefinitionsParser { get; set; }

    public IEnumerable<GeneratedFile> GenerateAll()
    {
        DefinitionsParser.ParseAll();

        var structs = GenerateStructs();
        var enums = GenerateEnums();
        var classes = GeneratedClasses();

        //return classes;
        return structs.Concat(enums).Concat(classes);
    }

    public void WriteAll()
    {
        var files = GenerateAll();
        WriteFiles(files);
    }

    private IEnumerable<GeneratedFile> GeneratedClasses()
    {
        var template = GetTemplate("NativeClass");
        var obj = new
        {
            _projectInfo.NameSpace,
            FriendlyName = _projectInfo.NameSpace,
            _projectInfo.NativeProjectName,
            Functions = DefinitionsParser.FunctionDefinitions
        };
        var scriptObject = new ScriptObject();
        scriptObject.Import(obj, renamer: _templateContext.MemberRenamer, filter: _templateContext.MemberFilter);
        _templateContext.PushGlobal(scriptObject);
        var code = template.Render(_templateContext).RemoveEmptyLines();
        _templateContext.PopGlobal();
        
        yield return new GeneratedFile($"{_projectInfo.NameSpace}NativeClass.cs", code);
    }

    private IEnumerable<GeneratedFile> GenerateEnums()
    {
        return DefinitionsParser.EnumDefinitions.Select(x => ParseWithTemplate("Enum", x));
    }

    private IEnumerable<GeneratedFile> GenerateStructs()
    {
        return DefinitionsParser.StructDefinitions
                                .Where(x => !TypeInfo.CustomDefinedTypes.Contains(x.Name) &&
                                            !TypeInfo.IgnoredEnums.Contains(x.Name))
                                .Select(x => ParseWithTemplate("Struct", x));
    }
    
    private static Template GetTemplate(string templateName)
    {
        if (!templateName.EndsWith(".template"))
        {
            templateName += ".template";
        }
        
        var templateString = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Templates", templateName));

        var template = Template.Parse(templateString);

        if (template.HasErrors)
        {
            foreach(var error in template.Messages)
            {
                Console.WriteLine(error);
            }
            Console.WriteLine("Waiting key ...");
            Console.Read();
        }

        return template;
    }

    private GeneratedFile ParseWithTemplate(string templateName, BaseDefinition data)
    {
        var template = GetTemplate(templateName);
        var scriptObject = new ScriptObject();
        scriptObject.Import(data, renamer: _templateContext.MemberRenamer, filter: _templateContext.MemberFilter);
        _templateContext.PushGlobal(scriptObject);
        var code = template.Render(_templateContext);
        _templateContext.PopGlobal();
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