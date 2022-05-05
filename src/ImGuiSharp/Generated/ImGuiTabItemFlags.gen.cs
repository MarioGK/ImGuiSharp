// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiTabItemFlags
{
    ImGuiTabItemFlagsNone = 0,
    ImGuiTabItemFlagsUnsavedDocument = 1 << 0,
    ImGuiTabItemFlagsSetSelected = 1 << 1,
    ImGuiTabItemFlagsNoCloseWithMiddleMouseButton = 1 << 2,
    ImGuiTabItemFlagsNoPushId = 1 << 3,
    ImGuiTabItemFlagsNoTooltip = 1 << 4,
    ImGuiTabItemFlagsNoReorder = 1 << 5,
    ImGuiTabItemFlagsLeading = 1 << 6,
    ImGuiTabItemFlagsTrailing = 1 << 7,
}
