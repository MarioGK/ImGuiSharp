namespace ImGuiSharp.Generator.Data;

internal class EnumDefinition : BaseDefinition
{
    public string FriendlyName => Name.EndsWith('_') ? Name[..^1] : Name;
    public List<EnumValue> Values { get; set; } = new();
    public string? Location { get; set; }
    
    public bool IsFlags => FriendlyName.Contains("Flags");
    
    public void SanitizeNames()
    {
        foreach (var member in Values)
        {
            member.Name = SanitizeMemberName(member.Name);
            member.Value = SanitizeMemberName(member.Value);
        }
    }

    private string SanitizeMemberName(string memberName)
    {
        var ret = memberName.Replace("_","");

        if (char.IsDigit(ret.First()))
        {
            ret = "_" + ret;
        }

        return ret;
    }
}