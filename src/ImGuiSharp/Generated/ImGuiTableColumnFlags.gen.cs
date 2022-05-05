// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiTableColumnFlags
{
    ImGuiTableColumnFlagsNone = 0,
    ImGuiTableColumnFlagsDisabled = 1 << 0,
    ImGuiTableColumnFlagsDefaultHide = 1 << 1,
    ImGuiTableColumnFlagsDefaultSort = 1 << 2,
    ImGuiTableColumnFlagsWidthStretch = 1 << 3,
    ImGuiTableColumnFlagsWidthFixed = 1 << 4,
    ImGuiTableColumnFlagsNoResize = 1 << 5,
    ImGuiTableColumnFlagsNoReorder = 1 << 6,
    ImGuiTableColumnFlagsNoHide = 1 << 7,
    ImGuiTableColumnFlagsNoClip = 1 << 8,
    ImGuiTableColumnFlagsNoSort = 1 << 9,
    ImGuiTableColumnFlagsNoSortAscending = 1 << 10,
    ImGuiTableColumnFlagsNoSortDescending = 1 << 11,
    ImGuiTableColumnFlagsNoHeaderLabel = 1 << 12,
    ImGuiTableColumnFlagsNoHeaderWidth = 1 << 13,
    ImGuiTableColumnFlagsPreferSortAscending = 1 << 14,
    ImGuiTableColumnFlagsPreferSortDescending = 1 << 15,
    ImGuiTableColumnFlagsIndentEnable = 1 << 16,
    ImGuiTableColumnFlagsIndentDisable = 1 << 17,
    ImGuiTableColumnFlagsIsEnabled = 1 << 24,
    ImGuiTableColumnFlagsIsVisible = 1 << 25,
    ImGuiTableColumnFlagsIsSorted = 1 << 26,
    ImGuiTableColumnFlagsIsHovered = 1 << 27,
    ImGuiTableColumnFlagsWidthMask = ImGuiTableColumnFlagsWidthStretch | ImGuiTableColumnFlagsWidthFixed,
    ImGuiTableColumnFlagsIndentMask = ImGuiTableColumnFlagsIndentEnable | ImGuiTableColumnFlagsIndentDisable,
    ImGuiTableColumnFlagsStatusMask = ImGuiTableColumnFlagsIsEnabled | ImGuiTableColumnFlagsIsVisible | ImGuiTableColumnFlagsIsSorted | ImGuiTableColumnFlagsIsHovered,
    ImGuiTableColumnFlagsNoDirectResize = 1 << 30,
}
