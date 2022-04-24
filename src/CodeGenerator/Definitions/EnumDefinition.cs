using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGenerator.Definitions;

internal class EnumDefinition
{
    private readonly Dictionary<string, string> _sanitizedNames;

    public string       Name         { get; }
    public string       FriendlyName { get; }
    public EnumMemberDefinition[] Members      { get; }

    public EnumDefinition(string name, EnumMemberDefinition[] elements)
    {
        Name         = name;
        FriendlyName = Name.EndsWith('_') ? Name[..^1] : Name;
        Members      = elements;

        _sanitizedNames = new Dictionary<string, string>();
        foreach (var el in elements)
        {
            _sanitizedNames.Add(el.Name, SanitizeMemberName(el.Name));
        }
    }

    public string SanitizeNames(string text)
    {
        return _sanitizedNames.Aggregate(text, (current, kvp) => current.Replace(kvp.Key, kvp.Value));
    }

    private string SanitizeMemberName(string memberName)
    {
        var ret = memberName;
        if (memberName.StartsWith(Name))
        {
            ret = memberName[Name.Length..];
            if (ret.StartsWith("_"))
            {
                ret = ret[1..];
            }
        }

        if (ret.EndsWith('_'))
        {
            ret = ret[..^1];
        }

        if (char.IsDigit(ret.First()))
        {
            ret = "_" + ret;
        }

        return ret;
    }
}