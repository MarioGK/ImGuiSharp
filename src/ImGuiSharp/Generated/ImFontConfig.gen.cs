// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImFontConfig
{
    public void* FontData;
    public int FontDataSize;
    public byte FontDataOwnedByAtlas;
    public int FontNo;
    public float SizePixels;
    public int OversampleH;
    public int OversampleV;
    public byte PixelSnapH;
    public Vector2 GlyphExtraSpacing;
    public Vector2 GlyphOffset;
    public ImWchar* GlyphRanges;
    public float GlyphMinAdvanceX;
    public float GlyphMaxAdvanceX;
    public byte MergeMode;
    public uint FontBuilderFlags;
    public float RasterizerMultiply;
    public ushort EllipsisChar;
    public byte Name[40];
    public ImFont* DstFont;

}
