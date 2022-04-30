// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiTableSortSpecs
{
    public ImGuiTableColumnSortSpecs* Specs;
    public int SpecsCount;
    public byte SpecsDirty;

}
