// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiFocusedFlags
{
    ImGuiFocusedFlagsNone = 0,
    ImGuiFocusedFlagsChildWindows = 1 << 0,
    ImGuiFocusedFlagsRootWindow = 1 << 1,
    ImGuiFocusedFlagsAnyWindow = 1 << 2,
    ImGuiFocusedFlagsNoPopupHierarchy = 1 << 3,
    ImGuiFocusedFlagsRootAndChildWindows = ImGuiFocusedFlagsRootWindow | ImGuiFocusedFlagsChildWindows,
}
