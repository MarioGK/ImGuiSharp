// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImFontGlyph
{
        public uint Colored;
        public uint Visible;
        public uint Codepoint;
        public float AdvanceX;
        public float X0;
        public float Y0;
        public float X1;
        public float Y1;
        public float U0;
        public float V0;
        public float U1;
        public float V1;
}
public unsafe partial struct ImFontGlyphPtr
{
    public ImFontGlyph* NativePtr { get; }
    public ImFontGlyphPtr(ImFontGlyph* nativePtr) => NativePtr = nativePtr;
    public ImFontGlyphPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyph*)nativePtr;
    public static implicit operator ImFontGlyphPtr(ImFontGlyph* nativePtr) => new (nativePtr);
    public static implicit operator ImFontGlyph* (ImFontGlyphPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImFontGlyphPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
