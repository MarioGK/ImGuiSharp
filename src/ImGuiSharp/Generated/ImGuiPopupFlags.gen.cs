// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiPopupFlags
{
    ImGuiPopupFlagsNone = 0,
    ImGuiPopupFlagsMouseButtonLeft = 0,
    ImGuiPopupFlagsMouseButtonRight = 1,
    ImGuiPopupFlagsMouseButtonMiddle = 2,
    ImGuiPopupFlagsMouseButtonMask = 0x1F,
    ImGuiPopupFlagsMouseButtonDefault = 1,
    ImGuiPopupFlagsNoOpenOverExistingPopup = 1 << 5,
    ImGuiPopupFlagsNoOpenOverItems = 1 << 6,
    ImGuiPopupFlagsAnyPopupId = 1 << 7,
    ImGuiPopupFlagsAnyPopupLevel = 1 << 8,
    ImGuiPopupFlagsAnyPopup = ImGuiPopupFlagsAnyPopupId | ImGuiPopupFlagsAnyPopupLevel,
}
