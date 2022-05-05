// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImDrawListFlags
{
    ImDrawListFlagsNone = 0,
    ImDrawListFlagsAntiAliasedLines = 1 << 0,
    ImDrawListFlagsAntiAliasedLinesUseTex = 1 << 1,
    ImDrawListFlagsAntiAliasedFill = 1 << 2,
    ImDrawListFlagsAllowVtxOffset = 1 << 3,
}
