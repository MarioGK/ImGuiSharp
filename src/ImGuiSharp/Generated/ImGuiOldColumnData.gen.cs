// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiOldColumnData
{
        public float OffsetNorm;
        public float OffsetNormBeforeResize;
        public ImGuiOldColumnFlags Flags;
        public ImRect ClipRect;
}
public unsafe partial struct ImGuiOldColumnDataPtr
{
    public ImGuiOldColumnData* NativePtr { get; }
    public ImGuiOldColumnDataPtr(ImGuiOldColumnData* nativePtr) => NativePtr = nativePtr;
    public ImGuiOldColumnDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiOldColumnData*)nativePtr;
    public static implicit operator ImGuiOldColumnDataPtr(ImGuiOldColumnData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiOldColumnData* (ImGuiOldColumnDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiOldColumnDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
