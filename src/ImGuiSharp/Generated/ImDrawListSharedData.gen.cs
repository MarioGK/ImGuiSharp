// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawListSharedData
{
        public Vector2 TexUvWhitePixel;
        public ImFont* Font;
        public float FontSize;
        public float CurveTessellationTol;
        public float CircleSegmentMaxError;
        public Vector4 ClipRectFullscreen;
        public ImDrawListFlags InitialFlags;
        public Vector2 ArcFastVtx0;
        public Vector2 ArcFastVtx1;
        public Vector2 ArcFastVtx2;
        public Vector2 ArcFastVtx3;
        public Vector2 ArcFastVtx4;
        public Vector2 ArcFastVtx5;
        public Vector2 ArcFastVtx6;
        public Vector2 ArcFastVtx7;
        public Vector2 ArcFastVtx8;
        public Vector2 ArcFastVtx9;
        public Vector2 ArcFastVtx10;
        public Vector2 ArcFastVtx11;
        public Vector2 ArcFastVtx12;
        public Vector2 ArcFastVtx13;
        public Vector2 ArcFastVtx14;
        public Vector2 ArcFastVtx15;
        public Vector2 ArcFastVtx16;
        public Vector2 ArcFastVtx17;
        public Vector2 ArcFastVtx18;
        public Vector2 ArcFastVtx19;
        public Vector2 ArcFastVtx20;
        public Vector2 ArcFastVtx21;
        public Vector2 ArcFastVtx22;
        public Vector2 ArcFastVtx23;
        public Vector2 ArcFastVtx24;
        public Vector2 ArcFastVtx25;
        public Vector2 ArcFastVtx26;
        public Vector2 ArcFastVtx27;
        public Vector2 ArcFastVtx28;
        public Vector2 ArcFastVtx29;
        public Vector2 ArcFastVtx30;
        public Vector2 ArcFastVtx31;
        public Vector2 ArcFastVtx32;
        public Vector2 ArcFastVtx33;
        public Vector2 ArcFastVtx34;
        public Vector2 ArcFastVtx35;
        public Vector2 ArcFastVtx36;
        public Vector2 ArcFastVtx37;
        public Vector2 ArcFastVtx38;
        public Vector2 ArcFastVtx39;
        public Vector2 ArcFastVtx40;
        public Vector2 ArcFastVtx41;
        public Vector2 ArcFastVtx42;
        public Vector2 ArcFastVtx43;
        public Vector2 ArcFastVtx44;
        public Vector2 ArcFastVtx45;
        public Vector2 ArcFastVtx46;
        public Vector2 ArcFastVtx47;
        public Vector2 ArcFastVtx48;
        public float ArcFastRadiusCutoff;
        public byte CircleSegmentCounts0;
        public byte CircleSegmentCounts1;
        public byte CircleSegmentCounts2;
        public byte CircleSegmentCounts3;
        public byte CircleSegmentCounts4;
        public byte CircleSegmentCounts5;
        public byte CircleSegmentCounts6;
        public byte CircleSegmentCounts7;
        public byte CircleSegmentCounts8;
        public byte CircleSegmentCounts9;
        public byte CircleSegmentCounts10;
        public byte CircleSegmentCounts11;
        public byte CircleSegmentCounts12;
        public byte CircleSegmentCounts13;
        public byte CircleSegmentCounts14;
        public byte CircleSegmentCounts15;
        public byte CircleSegmentCounts16;
        public byte CircleSegmentCounts17;
        public byte CircleSegmentCounts18;
        public byte CircleSegmentCounts19;
        public byte CircleSegmentCounts20;
        public byte CircleSegmentCounts21;
        public byte CircleSegmentCounts22;
        public byte CircleSegmentCounts23;
        public byte CircleSegmentCounts24;
        public byte CircleSegmentCounts25;
        public byte CircleSegmentCounts26;
        public byte CircleSegmentCounts27;
        public byte CircleSegmentCounts28;
        public byte CircleSegmentCounts29;
        public byte CircleSegmentCounts30;
        public byte CircleSegmentCounts31;
        public byte CircleSegmentCounts32;
        public byte CircleSegmentCounts33;
        public byte CircleSegmentCounts34;
        public byte CircleSegmentCounts35;
        public byte CircleSegmentCounts36;
        public byte CircleSegmentCounts37;
        public byte CircleSegmentCounts38;
        public byte CircleSegmentCounts39;
        public byte CircleSegmentCounts40;
        public byte CircleSegmentCounts41;
        public byte CircleSegmentCounts42;
        public byte CircleSegmentCounts43;
        public byte CircleSegmentCounts44;
        public byte CircleSegmentCounts45;
        public byte CircleSegmentCounts46;
        public byte CircleSegmentCounts47;
        public byte CircleSegmentCounts48;
        public byte CircleSegmentCounts49;
        public byte CircleSegmentCounts50;
        public byte CircleSegmentCounts51;
        public byte CircleSegmentCounts52;
        public byte CircleSegmentCounts53;
        public byte CircleSegmentCounts54;
        public byte CircleSegmentCounts55;
        public byte CircleSegmentCounts56;
        public byte CircleSegmentCounts57;
        public byte CircleSegmentCounts58;
        public byte CircleSegmentCounts59;
        public byte CircleSegmentCounts60;
        public byte CircleSegmentCounts61;
        public byte CircleSegmentCounts62;
        public byte CircleSegmentCounts63;
        public byte CircleSegmentCounts64;
        public Vector4* TexUvLines;
}
public unsafe partial struct ImDrawListSharedDataPtr
{
    public ImDrawListSharedData* NativePtr { get; }
    public ImDrawListSharedDataPtr(ImDrawListSharedData* nativePtr) => NativePtr = nativePtr;
    public ImDrawListSharedDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawListSharedData*)nativePtr;
    public static implicit operator ImDrawListSharedDataPtr(ImDrawListSharedData* nativePtr) => new (nativePtr);
    public static implicit operator ImDrawListSharedData* (ImDrawListSharedDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImDrawListSharedDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    public RangeAccessor<Vector2> ArcFastVtx => new (&NativePtr->ArcFastVtx0, 48);
    //TODO ARRAY ACCESSOR
    public RangeAccessor<byte> CircleSegmentCounts => new (&NativePtr->CircleSegmentCounts0, 64);
    //TODO ARRAY ACCESSOR
//TODO Functions
}
