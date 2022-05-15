// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiListClipperRange
{
        public int Min;
        public int Max;
        public byte PosToIndexConvert;
        public sbyte PosToIndexOffsetMin;
        public sbyte PosToIndexOffsetMax;
}
public unsafe partial struct ImGuiListClipperRangePtr
{
    public ImGuiListClipperRange* NativePtr { get; }
    public ImGuiListClipperRangePtr(ImGuiListClipperRange* nativePtr) => NativePtr = nativePtr;
    public ImGuiListClipperRangePtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipperRange*)nativePtr;
    public static implicit operator ImGuiListClipperRangePtr(ImGuiListClipperRange* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiListClipperRange* (ImGuiListClipperRangePtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiListClipperRangePtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
