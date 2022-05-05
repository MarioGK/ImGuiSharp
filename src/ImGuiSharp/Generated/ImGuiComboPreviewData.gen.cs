// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiComboPreviewData
{
        public ImRect PreviewRect;
        public Vector2 BackupCursorPos;
        public Vector2 BackupCursorMaxPos;
        public Vector2 BackupCursorPosPrevLine;
        public float BackupPrevLineTextBaseOffset;
        public ImGuiLayoutType BackupLayout;
}
public unsafe partial struct ImGuiComboPreviewDataPtr
{
    public ImGuiComboPreviewData* NativePtr { get; }
    public ImGuiComboPreviewDataPtr(ImGuiComboPreviewData* nativePtr) => NativePtr = nativePtr;
    public ImGuiComboPreviewDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiComboPreviewData*)nativePtr;
    public static implicit operator ImGuiComboPreviewDataPtr(ImGuiComboPreviewData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiComboPreviewData* (ImGuiComboPreviewDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiComboPreviewDataPtr(IntPtr nativePtr) => new (nativePtr);
}
