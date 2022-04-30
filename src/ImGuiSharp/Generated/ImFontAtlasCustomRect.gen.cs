// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImFontAtlasCustomRect
{
    public ushort Width;
    public ushort Height;
    public ushort X;
    public ushort Y;
    public uint GlyphID;
    public float GlyphAdvanceX;
    public Vector2 GlyphOffset;
    public ImFont* Font;

}
