
using System.Text;
using System.Text.RegularExpressions;
using ImGuiSharp.Generator.Data;

namespace ImGuiSharp.Generator.Helpers;

internal static class StringHelpers
{
    internal static string RemoveEmptyLines(this string s)
    {
        var sr = new StringReader(s);

        var sb = new StringBuilder();
        while (sr.ReadLine() is { } line)
            if (!string.IsNullOrWhiteSpace(line))
            {
                sb.AppendLine(line);
            }

        return sb.ToString();
    }
    
    internal static bool IsStringFieldName(string name)
    {
        return Regex.IsMatch(name, ".*Filename.*") || Regex.IsMatch(name, ".*Name");
    } 
    
    internal static string GetImVectorElementType(string typeStr)
    {
        var start = typeStr.IndexOf('<') + 1;
        var end = typeStr.IndexOf('>');
        var length = end - start;
        return typeStr.Substring(start, length);
    }
    
    internal static string GetSafeType(string nativeRet)
    {
        switch (nativeRet)
        {
            case "bool":
                return "bool";
            case "char*":
                return "string";
            case "ImWchar*":
            case "void*":
                return "IntPtr";
            default:
                return GetTypeString(nativeRet, false);
        }
    }
    
    internal static bool GetWrappedType(this string nativeType, out string wrappedType)
    {
        if (nativeType.StartsWith("Im") && nativeType.EndsWith("*") && !nativeType.StartsWith("ImVector"))
        {
            var pointerLevel = nativeType.Length - nativeType.IndexOf('*');
            if (pointerLevel > 1)
            {
                wrappedType = null;
                return false; // TODO
            }

            var nonPtrType = nativeType.Substring(0, nativeType.Length - pointerLevel);

            if (TypeInfo.Types.ContainsKey(nonPtrType))
            {
                wrappedType = null;
                return false;
            }

            wrappedType = nonPtrType + "Ptr";

            return true;
        }

        wrappedType = null;
        return false;
    }
    
    internal static bool CorrectDefaultValue(this string defaultVal, TypeDefinition tr, out string correctedDefault)
    {
        if (tr.Type is "ImGuiContext*" or "ImPlotContext*" or "EditorContext*")
        {
            correctedDefault = "IntPtr.Zero";
            return true;
        }

        if (TypeInfo.DefaultValues.TryGetValue(defaultVal, out correctedDefault))
        {
            return true;
        }

        if (tr.Type == "bool")
        {
            correctedDefault = bool.Parse(defaultVal) ? "1" : "0";
            return true;
        }

        if (defaultVal.Contains('%'))
        {
            correctedDefault = null;
            return false;
        }

        if (tr.IsEnum)
        {
            correctedDefault = defaultVal.StartsWith("-") ? $"({tr.Type})({defaultVal})" : $"({tr.Type}){defaultVal}";
            return true;
        }

        correctedDefault = defaultVal;
        return true;
    }
    
    internal static string GetTypeString(this string typeName, bool isFunctionPointer)
    {
        var pointerLevel = 0;
        if (typeName.EndsWith("**"))
        {
            pointerLevel = 2;
        }
        else if (typeName.EndsWith("*"))
        {
            pointerLevel = 1;
        }

        if (TypeInfo.Types.TryGetValue(typeName, out var typeStr))
        {
            return typeStr;
        }

        if (TypeInfo.Types.TryGetValue(typeName.Substring(0, typeName.Length - pointerLevel), out typeStr))
        {
            typeStr = typeStr + new string('*', pointerLevel);
        }
        else if (!TypeInfo.Types.TryGetValue(typeName, out typeStr))
        {
            typeStr = typeName;
            if (isFunctionPointer)
            {
                typeStr = "IntPtr";
            }
        }

        return typeStr;
    }
    
    internal static string CorrectIdentifier(this string identifier)
    {
        return TypeInfo.IdentifierReplacements.TryGetValue(identifier, out var replacement) ? replacement : identifier;
    }
}