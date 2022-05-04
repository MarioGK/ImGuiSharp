namespace ImGuiSharp.Generator.Data;

public class EnumDefinition
{
    public string Name { get; set; }

    public string FriendlyName => Name.EndsWith('_') ? Name[..^1] : Name;
    public List<EnumValue> Values { get; set; } = new();
    public string Location { get; set; }
}