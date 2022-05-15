// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImFontAtlas
{
        public ImFontAtlasFlags Flags;
        public IntPtr TexID;
        public int TexDesiredWidth;
        public int TexGlyphPadding;
        public byte Locked;
        public byte TexReady;
        public byte TexPixelsUseColors;
        public byte* TexPixelsAlpha8;
        public uint* TexPixelsRGBA32;
        public int TexWidth;
        public int TexHeight;
        public Vector2 TexUvScale;
        public Vector2 TexUvWhitePixel;
        public ImVector Fonts;
        public ImVector CustomRects;
        public ImVector ConfigData;
        public Vector4 TexUvLines0;
        public Vector4 TexUvLines1;
        public Vector4 TexUvLines2;
        public Vector4 TexUvLines3;
        public Vector4 TexUvLines4;
        public Vector4 TexUvLines5;
        public Vector4 TexUvLines6;
        public Vector4 TexUvLines7;
        public Vector4 TexUvLines8;
        public Vector4 TexUvLines9;
        public Vector4 TexUvLines10;
        public Vector4 TexUvLines11;
        public Vector4 TexUvLines12;
        public Vector4 TexUvLines13;
        public Vector4 TexUvLines14;
        public Vector4 TexUvLines15;
        public Vector4 TexUvLines16;
        public Vector4 TexUvLines17;
        public Vector4 TexUvLines18;
        public Vector4 TexUvLines19;
        public Vector4 TexUvLines20;
        public Vector4 TexUvLines21;
        public Vector4 TexUvLines22;
        public Vector4 TexUvLines23;
        public Vector4 TexUvLines24;
        public Vector4 TexUvLines25;
        public Vector4 TexUvLines26;
        public Vector4 TexUvLines27;
        public Vector4 TexUvLines28;
        public Vector4 TexUvLines29;
        public Vector4 TexUvLines30;
        public Vector4 TexUvLines31;
        public Vector4 TexUvLines32;
        public Vector4 TexUvLines33;
        public Vector4 TexUvLines34;
        public Vector4 TexUvLines35;
        public Vector4 TexUvLines36;
        public Vector4 TexUvLines37;
        public Vector4 TexUvLines38;
        public Vector4 TexUvLines39;
        public Vector4 TexUvLines40;
        public Vector4 TexUvLines41;
        public Vector4 TexUvLines42;
        public Vector4 TexUvLines43;
        public Vector4 TexUvLines44;
        public Vector4 TexUvLines45;
        public Vector4 TexUvLines46;
        public Vector4 TexUvLines47;
        public Vector4 TexUvLines48;
        public Vector4 TexUvLines49;
        public Vector4 TexUvLines50;
        public Vector4 TexUvLines51;
        public Vector4 TexUvLines52;
        public Vector4 TexUvLines53;
        public Vector4 TexUvLines54;
        public Vector4 TexUvLines55;
        public Vector4 TexUvLines56;
        public Vector4 TexUvLines57;
        public Vector4 TexUvLines58;
        public Vector4 TexUvLines59;
        public Vector4 TexUvLines60;
        public Vector4 TexUvLines61;
        public Vector4 TexUvLines62;
        public Vector4 TexUvLines63;
        public Vector4 TexUvLines64;
        public IntPtr* FontBuilderIO;
        public uint FontBuilderFlags;
        public int PackIdMouseCursors;
        public int PackIdLines;
}
public unsafe partial struct ImFontAtlasPtr
{
    public ImFontAtlas* NativePtr { get; }
    public ImFontAtlasPtr(ImFontAtlas* nativePtr) => NativePtr = nativePtr;
    public ImFontAtlasPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlas*)nativePtr;
    public static implicit operator ImFontAtlasPtr(ImFontAtlas* nativePtr) => new (nativePtr);
    public static implicit operator ImFontAtlas* (ImFontAtlasPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImFontAtlasPtr(IntPtr nativePtr) => new (nativePtr);
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
    public RangeAccessor<Vector4> TexUvLines => new (&NativePtr->TexUvLines0, 64);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
