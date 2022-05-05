// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiHoveredFlags
{
    ImGuiHoveredFlagsNone = 0,
    ImGuiHoveredFlagsChildWindows = 1 << 0,
    ImGuiHoveredFlagsRootWindow = 1 << 1,
    ImGuiHoveredFlagsAnyWindow = 1 << 2,
    ImGuiHoveredFlagsNoPopupHierarchy = 1 << 3,
    ImGuiHoveredFlagsAllowWhenBlockedByPopup = 1 << 5,
    ImGuiHoveredFlagsAllowWhenBlockedByActiveItem = 1 << 7,
    ImGuiHoveredFlagsAllowWhenOverlapped = 1 << 8,
    ImGuiHoveredFlagsAllowWhenDisabled = 1 << 9,
    ImGuiHoveredFlagsRectOnly = ImGuiHoveredFlagsAllowWhenBlockedByPopup | ImGuiHoveredFlagsAllowWhenBlockedByActiveItem | ImGuiHoveredFlagsAllowWhenOverlapped,
    ImGuiHoveredFlagsRootAndChildWindows = ImGuiHoveredFlagsRootWindow | ImGuiHoveredFlagsChildWindows,
}
