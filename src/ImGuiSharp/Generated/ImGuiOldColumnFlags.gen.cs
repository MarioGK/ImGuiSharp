// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiOldColumnFlags
{
    ImGuiOldColumnFlagsNone = 0,
    ImGuiOldColumnFlagsNoBorder = 1 << 0,
    ImGuiOldColumnFlagsNoResize = 1 << 1,
    ImGuiOldColumnFlagsNoPreserveWidths = 1 << 2,
    ImGuiOldColumnFlagsNoForceWithinWindow = 1 << 3,
    ImGuiOldColumnFlagsGrowParentContentsSize = 1 << 4,
}
