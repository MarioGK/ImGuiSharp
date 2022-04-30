using System.Text;
using System.Text.RegularExpressions;
using ImGuiSharp.Generator.Enumeration;

namespace ImGuiSharp.Generator;

public class Template
{
    private          string Content { get; set; }
    private readonly string _fileName;

    public Template(TemplateType templateType)
    {
        _fileName = $"{templateType.ToString()}.template";
        Read();
    }

    public Template(string fileName)
    {
        _fileName = fileName;
        Read();
    }

    private void Read()
    {
        var path    = Path.Combine(Directory.GetCurrentDirectory(), "Templates", _fileName);
        var content = File.ReadAllText(path);
        var sr      = new StringReader(content);

        var sb = new StringBuilder();
        while (sr.ReadLine() is { } line)
        {
            //Ignore comments
            if (line.StartsWith("/*"))
            {
                continue;
            }

            sb.AppendLine(line);
        }

        sr.Close();

        Content = sb.ToString();
    }

    public Template Copy()
    {
        return (Template)MemberwiseClone();
    }

    public void Set(string from, string to)
    {
        Content = Content.Replace($"|{from}|", to);
    }

    public void CleanUnused()
    {
            Content = Regex.Replace(Content, @"\|.+\|", "");
    }

    public override string ToString()
    {
        return Content;
    }
}