using Microsoft.CodeAnalysis;

namespace ImGuiSharp.Generator;

[Generator]
public class SourceGenerator : ISourceGenerator
{
    public SourceGenerator()
    {
        Generator = new CodeGenerator(ProjectInfos.ImGuiSharp);
    }

    private CodeGenerator Generator { get; }

    public void Initialize(GeneratorInitializationContext context)
    {
        #if DEBUG
        if (Debugger.IsAttached)
        {
            return;
        }

        //Debugger.Launch();
        Debug.WriteLine("Debugger launched!");
        #endif
    }

    public void Execute(GeneratorExecutionContext context)
    {
        var generatedFiles = Generator.GenerateAll();

        foreach (var generatedFile in generatedFiles) context.AddSource(generatedFile.FileName, generatedFile.Content);

        //context.AddSource("TestA.gen.cs", $"public static partial class TestA {{ public static int Test = {generatedFiles.Count()}; }}");
        //context.AddSource("a.gen.cs", ResourceReader.GetResource("Struct.template"));
    }
}