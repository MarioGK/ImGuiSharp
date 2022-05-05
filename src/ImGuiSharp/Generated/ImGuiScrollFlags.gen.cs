// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiScrollFlags
{
    ImGuiScrollFlagsNone = 0,
    ImGuiScrollFlagsKeepVisibleEdgeX = 1 << 0,
    ImGuiScrollFlagsKeepVisibleEdgeY = 1 << 1,
    ImGuiScrollFlagsKeepVisibleCenterX = 1 << 2,
    ImGuiScrollFlagsKeepVisibleCenterY = 1 << 3,
    ImGuiScrollFlagsAlwaysCenterX = 1 << 4,
    ImGuiScrollFlagsAlwaysCenterY = 1 << 5,
    ImGuiScrollFlagsNoScrollParent = 1 << 6,
    ImGuiScrollFlagsMaskX = ImGuiScrollFlagsKeepVisibleEdgeX | ImGuiScrollFlagsKeepVisibleCenterX | ImGuiScrollFlagsAlwaysCenterX,
    ImGuiScrollFlagsMaskY = ImGuiScrollFlagsKeepVisibleEdgeY | ImGuiScrollFlagsKeepVisibleCenterY | ImGuiScrollFlagsAlwaysCenterY,
}
