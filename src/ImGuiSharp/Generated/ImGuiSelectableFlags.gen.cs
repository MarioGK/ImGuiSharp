// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiSelectableFlags
{
    ImGuiSelectableFlagsNone = 0,
    ImGuiSelectableFlagsDontClosePopups = 1 << 0,
    ImGuiSelectableFlagsSpanAllColumns = 1 << 1,
    ImGuiSelectableFlagsAllowDoubleClick = 1 << 2,
    ImGuiSelectableFlagsDisabled = 1 << 3,
    ImGuiSelectableFlagsAllowItemOverlap = 1 << 4,
}
