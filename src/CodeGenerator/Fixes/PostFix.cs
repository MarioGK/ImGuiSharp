using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeGenerator.Fixes;

public class PostFix
{
    public List<IFix> Fixes { get; set; }
    public string          FileName     { get; set; }

    public PostFix(string fileName)
    {
        FileName = fileName;
        Fixes    = new List<IFix>();
    }

    public void ApplyAll(string rootPath)
    {
        var filePath = Path.Combine(rootPath, FileName);
        try
        {
            var content = File.ReadAllText(filePath);

            content = Fixes.Aggregate(content, (current, fix) => fix.Apply(current));

            File.WriteAllText(filePath, content);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.WriteLine("Error applying fixes to file: " + filePath);
        }
    }
    
    public PostFix AddFix(IFix fix)
    {
        Fixes.Add(fix);
        return this;
    }
    
    public PostFix AddFixes(params IFix[] fixes)
    {
        Fixes.AddRange(fixes);
        return this;
    }
    
    public PostFix RemoveLines(params string[] lines)
    {
        Fixes.Add(new RemoveLinesFix(lines));
        return this;
    }
    
    public PostFix RemoveLinesAfter( string line, int after)
    {
        Fixes.Add(new RemoveLinesAfterFix(line, after));
        return this;
    }
    
    public PostFix Replace(string from, string to)
    {
        Fixes.Add(new ReplaceFix(from, to));
        return this;
    }
}