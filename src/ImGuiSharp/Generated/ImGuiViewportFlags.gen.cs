// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiViewportFlags
{
    ImGuiViewportFlagsNone = 0,
    ImGuiViewportFlagsIsPlatformWindow = 1 << 0,
    ImGuiViewportFlagsIsPlatformMonitor = 1 << 1,
    ImGuiViewportFlagsOwnedByApp = 1 << 2,
}
