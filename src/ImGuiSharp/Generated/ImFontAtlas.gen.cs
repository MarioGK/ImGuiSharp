// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImFontAtlas
{
    public ImFontAtlasFlags Flags;
    public IntPtr TexID;
    public int TexDesiredWidth;
    public int TexGlyphPadding;
    public byte Locked;
    public byte TexReady;
    public byte TexPixelsUseColors;
    public unsigned char* TexPixelsAlpha8;
    public unsigned int* TexPixelsRGBA32;
    public int TexWidth;
    public int TexHeight;
    public Vector2 TexUvScale;
    public Vector2 TexUvWhitePixel;
    public ImVector Fonts;
    public ImVector CustomRects;
    public ImVector ConfigData;
    public Vector4 TexUvLines[(63)+1];
    public ImFontBuilderIO* FontBuilderIO;
    public uint FontBuilderFlags;
    public int PackIdMouseCursors;
    public int PackIdLines;

}
