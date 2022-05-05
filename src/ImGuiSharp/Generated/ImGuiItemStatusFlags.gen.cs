// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiItemStatusFlags
{
    ImGuiItemStatusFlagsNone = 0,
    ImGuiItemStatusFlagsHoveredRect = 1 << 0,
    ImGuiItemStatusFlagsHasDisplayRect = 1 << 1,
    ImGuiItemStatusFlagsEdited = 1 << 2,
    ImGuiItemStatusFlagsToggledSelection = 1 << 3,
    ImGuiItemStatusFlagsToggledOpen = 1 << 4,
    ImGuiItemStatusFlagsHasDeactivated = 1 << 5,
    ImGuiItemStatusFlagsDeactivated = 1 << 6,
    ImGuiItemStatusFlagsHoveredWindow = 1 << 7,
    ImGuiItemStatusFlagsFocusedByTabbing = 1 << 8,
}
