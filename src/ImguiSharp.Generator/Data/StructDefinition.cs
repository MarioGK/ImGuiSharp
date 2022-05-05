namespace ImGuiSharp.Generator.Data;

internal class StructDefinition : BaseDefinition
{
    public List<TypeDefinition> Fields = new();
    public string Location { get; set; }
    public string NameSpace { get; set; }
}