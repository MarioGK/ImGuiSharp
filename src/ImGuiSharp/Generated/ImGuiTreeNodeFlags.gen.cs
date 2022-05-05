// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiTreeNodeFlags
{
    ImGuiTreeNodeFlagsNone = 0,
    ImGuiTreeNodeFlagsSelected = 1 << 0,
    ImGuiTreeNodeFlagsFramed = 1 << 1,
    ImGuiTreeNodeFlagsAllowItemOverlap = 1 << 2,
    ImGuiTreeNodeFlagsNoTreePushOnOpen = 1 << 3,
    ImGuiTreeNodeFlagsNoAutoOpenOnLog = 1 << 4,
    ImGuiTreeNodeFlagsDefaultOpen = 1 << 5,
    ImGuiTreeNodeFlagsOpenOnDoubleClick = 1 << 6,
    ImGuiTreeNodeFlagsOpenOnArrow = 1 << 7,
    ImGuiTreeNodeFlagsLeaf = 1 << 8,
    ImGuiTreeNodeFlagsBullet = 1 << 9,
    ImGuiTreeNodeFlagsFramePadding = 1 << 10,
    ImGuiTreeNodeFlagsSpanAvailWidth = 1 << 11,
    ImGuiTreeNodeFlagsSpanFullWidth = 1 << 12,
    ImGuiTreeNodeFlagsNavLeftJumpsBackHere = 1 << 13,
    ImGuiTreeNodeFlagsCollapsingHeader = ImGuiTreeNodeFlagsFramed | ImGuiTreeNodeFlagsNoTreePushOnOpen | ImGuiTreeNodeFlagsNoAutoOpenOnLog,
}
