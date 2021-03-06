// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiWindowFlags
{
    ImGuiWindowFlagsNone = 0,
    ImGuiWindowFlagsNoTitleBar = 1 << 0,
    ImGuiWindowFlagsNoResize = 1 << 1,
    ImGuiWindowFlagsNoMove = 1 << 2,
    ImGuiWindowFlagsNoScrollbar = 1 << 3,
    ImGuiWindowFlagsNoScrollWithMouse = 1 << 4,
    ImGuiWindowFlagsNoCollapse = 1 << 5,
    ImGuiWindowFlagsAlwaysAutoResize = 1 << 6,
    ImGuiWindowFlagsNoBackground = 1 << 7,
    ImGuiWindowFlagsNoSavedSettings = 1 << 8,
    ImGuiWindowFlagsNoMouseInputs = 1 << 9,
    ImGuiWindowFlagsMenuBar = 1 << 10,
    ImGuiWindowFlagsHorizontalScrollbar = 1 << 11,
    ImGuiWindowFlagsNoFocusOnAppearing = 1 << 12,
    ImGuiWindowFlagsNoBringToFrontOnFocus = 1 << 13,
    ImGuiWindowFlagsAlwaysVerticalScrollbar = 1 << 14,
    ImGuiWindowFlagsAlwaysHorizontalScrollbar = 1<< 15,
    ImGuiWindowFlagsAlwaysUseWindowPadding = 1 << 16,
    ImGuiWindowFlagsNoNavInputs = 1 << 18,
    ImGuiWindowFlagsNoNavFocus = 1 << 19,
    ImGuiWindowFlagsUnsavedDocument = 1 << 20,
    ImGuiWindowFlagsNoNav = ImGuiWindowFlagsNoNavInputs | ImGuiWindowFlagsNoNavFocus,
    ImGuiWindowFlagsNoDecoration = ImGuiWindowFlagsNoTitleBar | ImGuiWindowFlagsNoResize | ImGuiWindowFlagsNoScrollbar | ImGuiWindowFlagsNoCollapse,
    ImGuiWindowFlagsNoInputs = ImGuiWindowFlagsNoMouseInputs | ImGuiWindowFlagsNoNavInputs | ImGuiWindowFlagsNoNavFocus,
    ImGuiWindowFlagsNavFlattened = 1 << 23,
    ImGuiWindowFlagsChildWindow = 1 << 24,
    ImGuiWindowFlagsTooltip = 1 << 25,
    ImGuiWindowFlagsPopup = 1 << 26,
    ImGuiWindowFlagsModal = 1 << 27,
    ImGuiWindowFlagsChildMenu = 1 << 28,
}
