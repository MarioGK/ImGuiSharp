using CodeGenerator.Extensions;

namespace CodeGenerator.Fixes;

/// <summary>
/// Removes lines that contains a certain string.
/// </summary>
public class RemoveLinesAfterFix : IFix
{
    public string StringToRemove { get; set; }
    public int        LinesLinesAfter              { get; set; }
    
    public RemoveLinesAfterFix(string stringToRemove, int linesAfter)
    {
        StringToRemove = stringToRemove;
        LinesLinesAfter     = linesAfter;
    }

    public string Apply(string content)
    {
        return content.RemoveLines(StringToRemove, LinesLinesAfter);
    }
}