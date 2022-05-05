// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiKeyModFlags
{
    ImGuiKeyModFlagsNone = 0,
    ImGuiKeyModFlagsCtrl = 1 << 0,
    ImGuiKeyModFlagsShift = 1 << 1,
    ImGuiKeyModFlagsAlt = 1 << 2,
    ImGuiKeyModFlagsSuper = 1 << 3,
}
