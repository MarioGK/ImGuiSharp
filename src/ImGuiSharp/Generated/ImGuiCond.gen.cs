// ReSharper disable once CheckNamespace
namespace ImGui;
public enum ImGuiCond
{
    ImGuiCondNone = 0,
    ImGuiCondAlways = 1 << 0,
    ImGuiCondOnce = 1 << 1,
    ImGuiCondFirstUseEver = 1 << 2,
    ImGuiCondAppearing = 1 << 3,
}
