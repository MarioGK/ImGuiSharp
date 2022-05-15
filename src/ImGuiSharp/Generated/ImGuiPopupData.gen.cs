// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiPopupData
{
        public uint PopupId;
        public ImGuiWindow* Window;
        public ImGuiWindow* SourceWindow;
        public int OpenFrameCount;
        public uint OpenParentId;
        public Vector2 OpenPopupPos;
        public Vector2 OpenMousePos;
}
public unsafe partial struct ImGuiPopupDataPtr
{
    public ImGuiPopupData* NativePtr { get; }
    public ImGuiPopupDataPtr(ImGuiPopupData* nativePtr) => NativePtr = nativePtr;
    public ImGuiPopupDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiPopupData*)nativePtr;
    public static implicit operator ImGuiPopupDataPtr(ImGuiPopupData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiPopupData* (ImGuiPopupDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiPopupDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
