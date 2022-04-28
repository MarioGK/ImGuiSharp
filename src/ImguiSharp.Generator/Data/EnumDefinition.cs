namespace ImguiSharp.Generator.Data;

public class EnumDefinition
{
    public string          Id       { get; set; }
    public List<EnumValue> Values   { get; set; } = new();
    public string          Location { get; set; }
}