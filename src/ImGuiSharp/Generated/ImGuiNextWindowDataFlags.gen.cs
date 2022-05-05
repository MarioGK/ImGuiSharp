// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiNextWindowDataFlags
{
    ImGuiNextWindowDataFlagsNone = 0,
    ImGuiNextWindowDataFlagsHasPos = 1 << 0,
    ImGuiNextWindowDataFlagsHasSize = 1 << 1,
    ImGuiNextWindowDataFlagsHasContentSize = 1 << 2,
    ImGuiNextWindowDataFlagsHasCollapsed = 1 << 3,
    ImGuiNextWindowDataFlagsHasSizeConstraint = 1 << 4,
    ImGuiNextWindowDataFlagsHasFocus = 1 << 5,
    ImGuiNextWindowDataFlagsHasBgAlpha = 1 << 6,
    ImGuiNextWindowDataFlagsHasScroll = 1 << 7,
}
