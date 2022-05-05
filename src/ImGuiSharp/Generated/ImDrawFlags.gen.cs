// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImDrawFlags
{
    ImDrawFlagsNone = 0,
    ImDrawFlagsClosed = 1 << 0,
    ImDrawFlagsRoundCornersTopLeft = 1 << 4,
    ImDrawFlagsRoundCornersTopRight = 1 << 5,
    ImDrawFlagsRoundCornersBottomLeft = 1 << 6,
    ImDrawFlagsRoundCornersBottomRight = 1 << 7,
    ImDrawFlagsRoundCornersNone = 1 << 8,
    ImDrawFlagsRoundCornersTop = ImDrawFlagsRoundCornersTopLeft | ImDrawFlagsRoundCornersTopRight,
    ImDrawFlagsRoundCornersBottom = ImDrawFlagsRoundCornersBottomLeft | ImDrawFlagsRoundCornersBottomRight,
    ImDrawFlagsRoundCornersLeft = ImDrawFlagsRoundCornersBottomLeft | ImDrawFlagsRoundCornersTopLeft,
    ImDrawFlagsRoundCornersRight = ImDrawFlagsRoundCornersBottomRight | ImDrawFlagsRoundCornersTopRight,
    ImDrawFlagsRoundCornersAll = ImDrawFlagsRoundCornersTopLeft | ImDrawFlagsRoundCornersTopRight | ImDrawFlagsRoundCornersBottomLeft | ImDrawFlagsRoundCornersBottomRight,
    ImDrawFlagsRoundCornersDefault = ImDrawFlagsRoundCornersAll,
    ImDrawFlagsRoundCornersMask = ImDrawFlagsRoundCornersAll | ImDrawFlagsRoundCornersNone,
}
