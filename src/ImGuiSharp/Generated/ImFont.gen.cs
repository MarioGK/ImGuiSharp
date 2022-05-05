// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImFont
{
        public ImVector IndexAdvanceX;
        public float FallbackAdvanceX;
        public float FontSize;
        public ImVector IndexLookup;
        public ImVector Glyphs;
        public ImFontGlyph* FallbackGlyph;
        public ImFontAtlas* ContainerAtlas;
        public ImFontConfig* ConfigData;
        public short ConfigDataCount;
        public ushort FallbackChar;
        public ushort EllipsisChar;
        public ushort DotChar;
        public byte DirtyLookupTables;
        public float Scale;
        public float Ascent;
        public float Descent;
        public int MetricsTotalSurface;
        public byte Used4kPagesMap0;
        public byte Used4kPagesMap1;
        public byte Used4kPagesMap2;
}
public unsafe partial struct ImFontPtr
{
    public ImFont* NativePtr { get; }
    public ImFontPtr(ImFont* nativePtr) => NativePtr = nativePtr;
    public ImFontPtr(IntPtr nativePtr) => NativePtr = (ImFont*)nativePtr;
    public static implicit operator ImFontPtr(ImFont* nativePtr) => new (nativePtr);
    public static implicit operator ImFont* (ImFontPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImFontPtr(IntPtr nativePtr) => new (nativePtr);
    public RangeAccessor<byte> Used4kPagesMap => new (&NativePtr->Used4kPagesMap0, 2);
}
