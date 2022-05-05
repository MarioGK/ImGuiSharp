// ReSharper disable once CheckNamespace
namespace ImGui;
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
public unsafe partial struct ImFontAtlasCustomRectPtr
{
    public ImFontAtlasCustomRect* NativePtr { get; }
    public ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* nativePtr) => NativePtr = nativePtr;
    public ImFontAtlasCustomRectPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlasCustomRect*)nativePtr;
    public static implicit operator ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* nativePtr) => new (nativePtr);
    public static implicit operator ImFontAtlasCustomRect* (ImFontAtlasCustomRectPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImFontAtlasCustomRectPtr(IntPtr nativePtr) => new (nativePtr);
}
