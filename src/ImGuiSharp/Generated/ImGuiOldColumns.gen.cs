// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiOldColumns
{
        public uint ID;
        public ImGuiOldColumnFlags Flags;
        public byte IsFirstFrame;
        public byte IsBeingResized;
        public int Current;
        public int Count;
        public float OffMinX;
        public float OffMaxX;
        public float LineMinY;
        public float LineMaxY;
        public float HostCursorPosY;
        public float HostCursorMaxPosX;
        public ImRect HostInitialClipRect;
        public ImRect HostBackupClipRect;
        public ImRect HostBackupParentWorkRect;
        public ImVector Columns;
        public ImDrawListSplitter Splitter;
}
public unsafe partial struct ImGuiOldColumnsPtr
{
    public ImGuiOldColumns* NativePtr { get; }
    public ImGuiOldColumnsPtr(ImGuiOldColumns* nativePtr) => NativePtr = nativePtr;
    public ImGuiOldColumnsPtr(IntPtr nativePtr) => NativePtr = (ImGuiOldColumns*)nativePtr;
    public static implicit operator ImGuiOldColumnsPtr(ImGuiOldColumns* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiOldColumns* (ImGuiOldColumnsPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiOldColumnsPtr(IntPtr nativePtr) => new (nativePtr);
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
//TODO Functions
}
