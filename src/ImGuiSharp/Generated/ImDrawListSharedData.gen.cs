// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImDrawListSharedData
{
    public Vector2 TexUvWhitePixel;
    public ImFont* Font;
    public float FontSize;
    public float CurveTessellationTol;
    public float CircleSegmentMaxError;
    public Vector4 ClipRectFullscreen;
    public ImDrawListFlags InitialFlags;
    public Vector2 ArcFastVtx[48];
    public float ArcFastRadiusCutoff;
    public byte CircleSegmentCounts[64];
    public ImVec4* TexUvLines;

}
