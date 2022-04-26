namespace CodeGenerator.Fixes;

public interface IFix
{
    /// <summary>
    /// Apply the fix to the given file.
    /// </summary>
    /// <param name="content">File contents</param>
    /// <returns>Content with applied fixes</returns>
    string Apply(string content);
}