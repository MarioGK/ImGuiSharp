// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiNavDirSourceFlags
{
    ImGuiNavDirSourceFlagsNone = 0,
    ImGuiNavDirSourceFlagsRawKeyboard = 1 << 0,
    ImGuiNavDirSourceFlagsKeyboard = 1 << 1,
    ImGuiNavDirSourceFlagsPadDPad = 1 << 2,
    ImGuiNavDirSourceFlagsPadLStick = 1 << 3,
}
