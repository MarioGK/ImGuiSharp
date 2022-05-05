// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiNavHighlightFlags
{
    ImGuiNavHighlightFlagsNone = 0,
    ImGuiNavHighlightFlagsTypeDefault = 1 << 0,
    ImGuiNavHighlightFlagsTypeThin = 1 << 1,
    ImGuiNavHighlightFlagsAlwaysDraw = 1 << 2,
    ImGuiNavHighlightFlagsNoRounding = 1 << 3,
}
