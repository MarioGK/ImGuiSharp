using ImGuiSharp.Generator.Models;

namespace ImGuiSharp.Generator;

public class Generator
{
    public Generator(ProjectInfo projectInfo, string output)
    {
        Output = output;
        Parser = new Parser(projectInfo);
    }

    public Parser Parser { get; set; }
    public string Output { get; set; }

    public void Generate()
    {
        Parser.ParseAll();
    }
}