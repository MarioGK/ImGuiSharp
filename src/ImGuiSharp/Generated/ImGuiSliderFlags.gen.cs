// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiSliderFlags
{
    ImGuiSliderFlagsNone = 0,
    ImGuiSliderFlagsAlwaysClamp = 1 << 4,
    ImGuiSliderFlagsLogarithmic = 1 << 5,
    ImGuiSliderFlagsNoRoundToFormat = 1 << 6,
    ImGuiSliderFlagsNoInput = 1 << 7,
    ImGuiSliderFlagsInvalidMask = 0x7000000F,
}
