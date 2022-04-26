using System.IO;
using System.Text;

namespace CodeGenerator.Extensions;

public static class StringExtensions
{
    /// <summary>
    /// Removes all lines that contain the specified string.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="sRemove"></param>
    /// <returns></returns>
    public static string RemoveLine(this string s, string sRemove)
    {
        var sr = new StringReader(s);

        var sb = new StringBuilder();
        while (sr.ReadLine() is { } line)
        {
            if (!line.Contains(sRemove))
            {
                sb.AppendLine(line);
            }
        }
        return sb.ToString();
    }
    
    public static string RemoveLines(this string s, params string[] strings)
    {
        var sr = new StringReader(s);

        var sb = new StringBuilder();
        while (sr.ReadLine() is { } line)
        {
            foreach (var sRemove in strings)
            {
                if (!line.Contains(sRemove))
                {
                    sb.AppendLine(line);
                }
            }
        }
        return sb.ToString();
    }


    /// <summary>
    /// Removes all lines that contain the specified string and extra lines if necessary.
    /// </summary>
    /// <param name="s"></param>
    /// <param name="sRemove"></param>
    /// <param name="nrLinesAfter"></param>
    /// <returns></returns>
    public static string RemoveLines(this string s, string sRemove, int nrLinesAfter)
    {
        var dontAtFor = 0;
        var sr        = new StringReader(s);

        var    sb = new StringBuilder();
        while (sr.ReadLine() is { } line)
        {


            if (line.Contains(sRemove))
            {
                dontAtFor = nrLinesAfter;
            }
            if (dontAtFor > 0)
            {
                dontAtFor--;
            }
            if (dontAtFor == 0)
            {
                sb.AppendLine(line);
            }
        }
        return sb.ToString();

    }
}