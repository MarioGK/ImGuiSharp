// ReSharper disable once CheckNamespace
namespace ImGui;
public enum ImGuiContextHookType
{
    ImGuiContextHookTypeNewFramePre = 0,
    ImGuiContextHookTypeNewFramePost = 1,
    ImGuiContextHookTypeEndFramePre = 2,
    ImGuiContextHookTypeEndFramePost = 3,
    ImGuiContextHookTypeRenderPre = 4,
    ImGuiContextHookTypeRenderPost = 5,
    ImGuiContextHookTypeShutdown = 6,
    ImGuiContextHookTypePendingRemoval = 7,
}
