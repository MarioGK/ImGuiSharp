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
        Name = name;
        if (Name.EndsWith('_'))
        {
            FriendlyName = Name.Substring(0, Name.Length - 1);
        }
        else
        {
            FriendlyName = Name;
        }
        Members = elements;

        _sanitizedNames = new Dictionary<string, string>();
        foreach (var el in elements)
        {
            _sanitizedNames.Add(el.Name, SanitizeMemberName(el.Name));
        }
    }

    public string SanitizeNames(string text)
    {
        foreach (var kvp in _sanitizedNames)
        {
            text = text.Replace(kvp.Key, kvp.Value);
        }

        return text;
    }

    private string SanitizeMemberName(string memberName)
    {
        var ret = memberName;
        if (memberName.StartsWith(Name))
        {
            ret = memberName.Substring(Name.Length);
            if (ret.StartsWith("_"))
            {
                ret = ret.Substring(1);
            }
        }

        if (ret.EndsWith('_'))
        {
            ret = ret.Substring(0, ret.Length - 1);
        }

        if (Char.IsDigit(ret.First()))
            ret = "_" + ret;

        return ret;
    }
}