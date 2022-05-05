// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiGroupData
{
        public uint WindowID;
        public Vector2 BackupCursorPos;
        public Vector2 BackupCursorMaxPos;
        public ImVec1 BackupIndent;
        public ImVec1 BackupGroupOffset;
        public Vector2 BackupCurrLineSize;
        public float BackupCurrLineTextBaseOffset;
        public uint BackupActiveIdIsAlive;
        public byte BackupActiveIdPreviousFrameIsAlive;
        public byte BackupHoveredIdIsAlive;
        public byte EmitItem;
}
public unsafe partial struct ImGuiGroupDataPtr
{
    public ImGuiGroupData* NativePtr { get; }
    public ImGuiGroupDataPtr(ImGuiGroupData* nativePtr) => NativePtr = nativePtr;
    public ImGuiGroupDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiGroupData*)nativePtr;
    public static implicit operator ImGuiGroupDataPtr(ImGuiGroupData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiGroupData* (ImGuiGroupDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiGroupDataPtr(IntPtr nativePtr) => new (nativePtr);
}
