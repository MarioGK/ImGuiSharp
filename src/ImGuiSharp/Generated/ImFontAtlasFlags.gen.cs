// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImFontAtlasFlags
{
    ImFontAtlasFlagsNone = 0,
    ImFontAtlasFlagsNoPowerOfTwoHeight = 1 << 0,
    ImFontAtlasFlagsNoMouseCursors = 1 << 1,
    ImFontAtlasFlagsNoBakedLines = 1 << 2,
}
