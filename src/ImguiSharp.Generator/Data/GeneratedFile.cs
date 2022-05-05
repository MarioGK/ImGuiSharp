namespace ImGuiSharp.Generator.Data;
internal class GeneratedFile
{
    public GeneratedFile(string fileName, string content)
    {
        FileName = fileName;
        Content = content;
    }

    public string FileName { get; set; }
    public string  Content { get; set; }
}