// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiNavItemData
{
        public ImGuiWindow* Window;
        public uint ID;
        public uint FocusScopeId;
        public ImRect RectRel;
        public ImGuiItemFlags InFlags;
        public float DistBox;
        public float DistCenter;
        public float DistAxial;
}
public unsafe partial struct ImGuiNavItemDataPtr
{
    public ImGuiNavItemData* NativePtr { get; }
    public ImGuiNavItemDataPtr(ImGuiNavItemData* nativePtr) => NativePtr = nativePtr;
    public ImGuiNavItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNavItemData*)nativePtr;
    public static implicit operator ImGuiNavItemDataPtr(ImGuiNavItemData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiNavItemData* (ImGuiNavItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiNavItemDataPtr(IntPtr nativePtr) => new (nativePtr);
}
