namespace ImGuiSharp.Generator.Data;

public class StructDefinition : BaseDefinition
{
    public List<TypeDefinition> Fields = new();
    public string Location { get; set; }
    public string NameSpace { get; set; }
}