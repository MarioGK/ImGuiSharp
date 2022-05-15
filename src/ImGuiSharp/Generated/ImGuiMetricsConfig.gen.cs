// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiMetricsConfig
{
        public byte ShowStackTool;
        public byte ShowWindowsRects;
        public byte ShowWindowsBeginOrder;
        public byte ShowTablesRects;
        public byte ShowDrawCmdMesh;
        public byte ShowDrawCmdBoundingBoxes;
        public int ShowWindowsRectsType;
        public int ShowTablesRectsType;
}
public unsafe partial struct ImGuiMetricsConfigPtr
{
    public ImGuiMetricsConfig* NativePtr { get; }
    public ImGuiMetricsConfigPtr(ImGuiMetricsConfig* nativePtr) => NativePtr = nativePtr;
    public ImGuiMetricsConfigPtr(IntPtr nativePtr) => NativePtr = (ImGuiMetricsConfig*)nativePtr;
    public static implicit operator ImGuiMetricsConfigPtr(ImGuiMetricsConfig* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiMetricsConfig* (ImGuiMetricsConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiMetricsConfigPtr(IntPtr nativePtr) => new (nativePtr);
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
