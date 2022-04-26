namespace CodeGenerator.Fixes;

public class ReplaceFix : IFix
{
    public string From { get; set; }
    public string      To    { get; set; }

    public ReplaceFix(string from, string to)
    {
        From = from;
        To = to;
    }

    public string Apply(string content)
    {
        return content.Replace(From, To);
    }
}