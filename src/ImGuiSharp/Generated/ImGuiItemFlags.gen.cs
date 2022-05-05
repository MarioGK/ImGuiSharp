// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiItemFlags
{
    ImGuiItemFlagsNone = 0,
    ImGuiItemFlagsNoTabStop = 1 << 0,
    ImGuiItemFlagsButtonRepeat = 1 << 1,
    ImGuiItemFlagsDisabled = 1 << 2,
    ImGuiItemFlagsNoNav = 1 << 3,
    ImGuiItemFlagsNoNavDefaultFocus = 1 << 4,
    ImGuiItemFlagsSelectableDontClosePopup = 1 << 5,
    ImGuiItemFlagsMixedValue = 1 << 6,
    ImGuiItemFlagsReadOnly = 1 << 7,
    ImGuiItemFlagsInputable = 1 << 8,
}
