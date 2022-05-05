// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiActivateFlags
{
    ImGuiActivateFlagsNone = 0,
    ImGuiActivateFlagsPreferInput = 1 << 0,
    ImGuiActivateFlagsPreferTweak = 1 << 1,
    ImGuiActivateFlagsTryToPreserveState = 1 << 2,
}
