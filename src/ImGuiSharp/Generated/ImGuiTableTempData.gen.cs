// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTableTempData
{
        public int TableIndex;
        public float LastTimeActive;
        public Vector2 UserOuterSize;
        public ImDrawListSplitter DrawSplitter;
        public ImRect HostBackupWorkRect;
        public ImRect HostBackupParentWorkRect;
        public Vector2 HostBackupPrevLineSize;
        public Vector2 HostBackupCurrLineSize;
        public Vector2 HostBackupCursorMaxPos;
        public ImVec1 HostBackupColumnsOffset;
        public float HostBackupItemWidth;
        public int HostBackupItemWidthStackSize;
}
public unsafe partial struct ImGuiTableTempDataPtr
{
    public ImGuiTableTempData* NativePtr { get; }
    public ImGuiTableTempDataPtr(ImGuiTableTempData* nativePtr) => NativePtr = nativePtr;
    public ImGuiTableTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableTempData*)nativePtr;
    public static implicit operator ImGuiTableTempDataPtr(ImGuiTableTempData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTableTempData* (ImGuiTableTempDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTableTempDataPtr(IntPtr nativePtr) => new (nativePtr);
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
