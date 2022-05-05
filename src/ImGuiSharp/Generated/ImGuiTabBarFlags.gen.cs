// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiTabBarFlags
{
    ImGuiTabBarFlagsNone = 0,
    ImGuiTabBarFlagsReorderable = 1 << 0,
    ImGuiTabBarFlagsAutoSelectNewTabs = 1 << 1,
    ImGuiTabBarFlagsTabListPopupButton = 1 << 2,
    ImGuiTabBarFlagsNoCloseWithMiddleMouseButton = 1 << 3,
    ImGuiTabBarFlagsNoTabListScrollingButtons = 1 << 4,
    ImGuiTabBarFlagsNoTooltip = 1 << 5,
    ImGuiTabBarFlagsFittingPolicyResizeDown = 1 << 6,
    ImGuiTabBarFlagsFittingPolicyScroll = 1 << 7,
    ImGuiTabBarFlagsFittingPolicyMask = ImGuiTabBarFlagsFittingPolicyResizeDown | ImGuiTabBarFlagsFittingPolicyScroll,
    ImGuiTabBarFlagsFittingPolicyDefault = ImGuiTabBarFlagsFittingPolicyResizeDown,
}
