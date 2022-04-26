using CodeGenerator.Extensions;

namespace CodeGenerator.Fixes;

/// <summary>
/// Removes lines that contains a certain string.
/// </summary>
public class RemoveLinesFix : IFix
{
    public string[] StringToRemove { get; set; }
    
    public RemoveLinesFix(params string[] stringToRemove)
    {
        StringToRemove = stringToRemove;
    }

    public string Apply(string content)
    {
        return content.RemoveLines(StringToRemove);
    }
}