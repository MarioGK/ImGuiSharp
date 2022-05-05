namespace ImGuiSharp.Generator.Data;

internal class EnumDefinition : BaseDefinition
{
    
    public List<EnumValue> Values { get; set; } = new();
    public string? Location { get; set; }

    public string NameSpace { get; set; }
    
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
        return ret;
    }
}