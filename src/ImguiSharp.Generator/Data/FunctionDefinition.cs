namespace ImGuiSharp.Generator.Data;

internal class FunctionDefinition : BaseDefinition
{
    public List<FunctionOverload> Overloads { get; set; } = new();
}