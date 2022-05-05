// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiButtonFlags
{
    ImGuiButtonFlagsNone = 0,
    ImGuiButtonFlagsMouseButtonLeft = 1 << 0,
    ImGuiButtonFlagsMouseButtonRight = 1 << 1,
    ImGuiButtonFlagsMouseButtonMiddle = 1 << 2,
    ImGuiButtonFlagsMouseButtonMask = ImGuiButtonFlagsMouseButtonLeft | ImGuiButtonFlagsMouseButtonRight | ImGuiButtonFlagsMouseButtonMiddle,
    ImGuiButtonFlagsMouseButtonDefault = ImGuiButtonFlagsMouseButtonLeft,
}
