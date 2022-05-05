// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiSeparatorFlags
{
    ImGuiSeparatorFlagsNone = 0,
    ImGuiSeparatorFlagsHorizontal = 1 << 0,
    ImGuiSeparatorFlagsVertical = 1 << 1,
    ImGuiSeparatorFlagsSpanAllColumns = 1 << 2,
}
