namespace ImGuiSharp.Generator.Helpers;

public static class ListHelpers
{
    public static bool ContainsAny(this string list, IEnumerable<string> values)
    {
        return values.Any(list.Contains);
    }
    
    public static bool ContainsAny(this IEnumerable<string> list, IEnumerable<string> values)
    {
        return values.Any(list.Contains);
    }
    
    public static bool AnyStartsWith(this IEnumerable<string> list, string value)
    {
        return list.Any(s => s.StartsWith(value));
    }
}