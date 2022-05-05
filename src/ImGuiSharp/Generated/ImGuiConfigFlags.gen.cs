// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiConfigFlags
{
    ImGuiConfigFlagsNone = 0,
    ImGuiConfigFlagsNavEnableKeyboard = 1 << 0,
    ImGuiConfigFlagsNavEnableGamepad = 1 << 1,
    ImGuiConfigFlagsNavEnableSetMousePos = 1 << 2,
    ImGuiConfigFlagsNavNoCaptureKeyboard = 1 << 3,
    ImGuiConfigFlagsNoMouse = 1 << 4,
    ImGuiConfigFlagsNoMouseCursorChange = 1 << 5,
    ImGuiConfigFlagsIsSRGB = 1 << 20,
    ImGuiConfigFlagsIsTouchScreen = 1 << 21,
}
