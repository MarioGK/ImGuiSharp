// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiDragDropFlags
{
    ImGuiDragDropFlagsNone = 0,
    ImGuiDragDropFlagsSourceNoPreviewTooltip = 1 << 0,
    ImGuiDragDropFlagsSourceNoDisableHover = 1 << 1,
    ImGuiDragDropFlagsSourceNoHoldToOpenOthers = 1 << 2,
    ImGuiDragDropFlagsSourceAllowNullID = 1 << 3,
    ImGuiDragDropFlagsSourceExtern = 1 << 4,
    ImGuiDragDropFlagsSourceAutoExpirePayload = 1 << 5,
    ImGuiDragDropFlagsAcceptBeforeDelivery = 1 << 10,
    ImGuiDragDropFlagsAcceptNoDrawDefaultRect = 1 << 11,
    ImGuiDragDropFlagsAcceptNoPreviewTooltip = 1 << 12,
    ImGuiDragDropFlagsAcceptPeekOnly = ImGuiDragDropFlagsAcceptBeforeDelivery | ImGuiDragDropFlagsAcceptNoDrawDefaultRect,
}
