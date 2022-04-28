namespace ImGuiSharp.Generator.Data;

public class StructDefinition
{
    public List<StructField> Fields = new();
    public string            Name     { get; set; }
    public string            Location { get; set; }
}