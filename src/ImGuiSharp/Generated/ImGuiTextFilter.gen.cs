// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiTextFilter
{
    public byte InputBuf[256];
    public ImVector Filters;
    public int CountGrep;

}
