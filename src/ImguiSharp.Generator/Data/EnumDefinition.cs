namespace ImGuiSharp.Generator.Data;

public class EnumDefinition : BaseDefinition
{
    public string FriendlyName => Name.EndsWith('_') ? Name[..^1] : Name;
    public List<EnumValue> Values { get; set; } = new();
    public string Location { get; set; }
    
    public bool IsFlags => FriendlyName.Contains("Flags");
}