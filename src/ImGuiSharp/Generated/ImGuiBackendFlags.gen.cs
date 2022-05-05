// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiBackendFlags
{
    ImGuiBackendFlagsNone = 0,
    ImGuiBackendFlagsHasGamepad = 1 << 0,
    ImGuiBackendFlagsHasMouseCursors = 1 << 1,
    ImGuiBackendFlagsHasSetMousePos = 1 << 2,
    ImGuiBackendFlagsRendererHasVtxOffset = 1 << 3,
}
