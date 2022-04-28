using ImguiSharp.Generator.Models;

namespace ImguiSharp.Generator;

public class Generator
{
    public Parser Parser { get; set; }
    public string      Output      { get; set; }
    
    public Generator(ProjectInfo projectInfo, string output)
    {
        Output = output;
        Parser = new Parser(projectInfo);
    }
    
    public void Generate()
    {
        Parser.ParseAll();
    }
}