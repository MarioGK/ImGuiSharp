// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiNextItemDataFlags
{
    ImGuiNextItemDataFlagsNone = 0,
    ImGuiNextItemDataFlagsHasWidth = 1 << 0,
    ImGuiNextItemDataFlagsHasOpen = 1 << 1,
}
