// ReSharper disable once CheckNamespace
namespace ImGui;
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
        public ushort* GlyphRanges;
        public float GlyphMinAdvanceX;
        public float GlyphMaxAdvanceX;
        public byte MergeMode;
        public uint FontBuilderFlags;
        public float RasterizerMultiply;
        public ushort EllipsisChar;
        public fixed byte Name[40];
        public ImFont* DstFont;
}
public unsafe partial struct ImFontConfigPtr
{
    public ImFontConfig* NativePtr { get; }
    public ImFontConfigPtr(ImFontConfig* nativePtr) => NativePtr = nativePtr;
    public ImFontConfigPtr(IntPtr nativePtr) => NativePtr = (ImFontConfig*)nativePtr;
    public static implicit operator ImFontConfigPtr(ImFontConfig* nativePtr) => new (nativePtr);
    public static implicit operator ImFontConfig* (ImFontConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImFontConfigPtr(IntPtr nativePtr) => new (nativePtr);
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
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    public RangeAccessor<byte> Name => new (NativePtr->Name, 40);
    //TODO ARRAY ACCESSOR
//TODO Functions
}
