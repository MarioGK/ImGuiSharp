// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiNavMoveFlags
{
    ImGuiNavMoveFlagsNone = 0,
    ImGuiNavMoveFlagsLoopX = 1 << 0,
    ImGuiNavMoveFlagsLoopY = 1 << 1,
    ImGuiNavMoveFlagsWrapX = 1 << 2,
    ImGuiNavMoveFlagsWrapY = 1 << 3,
    ImGuiNavMoveFlagsAllowCurrentNavId = 1 << 4,
    ImGuiNavMoveFlagsAlsoScoreVisibleSet = 1 << 5,
    ImGuiNavMoveFlagsScrollToEdgeY = 1 << 6,
    ImGuiNavMoveFlagsForwarded = 1 << 7,
    ImGuiNavMoveFlagsDebugNoResult = 1 << 8,
    ImGuiNavMoveFlagsFocusApi = 1 << 9,
    ImGuiNavMoveFlagsTabbing = 1 << 10,
    ImGuiNavMoveFlagsActivate = 1 << 11,
    ImGuiNavMoveFlagsDontSetNavHighlight = 1 << 12,
}
