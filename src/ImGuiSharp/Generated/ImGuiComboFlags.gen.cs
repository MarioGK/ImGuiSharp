// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiComboFlags
{
    ImGuiComboFlagsNone = 0,
    ImGuiComboFlagsPopupAlignLeft = 1 << 0,
    ImGuiComboFlagsHeightSmall = 1 << 1,
    ImGuiComboFlagsHeightRegular = 1 << 2,
    ImGuiComboFlagsHeightLarge = 1 << 3,
    ImGuiComboFlagsHeightLargest = 1 << 4,
    ImGuiComboFlagsNoArrowButton = 1 << 5,
    ImGuiComboFlagsNoPreview = 1 << 6,
    ImGuiComboFlagsHeightMask = ImGuiComboFlagsHeightSmall | ImGuiComboFlagsHeightRegular | ImGuiComboFlagsHeightLarge | ImGuiComboFlagsHeightLargest,
}
