// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiNextItemData
{
        public ImGuiNextItemDataFlags Flags;
        public float Width;
        public uint FocusScopeId;
        public ImGuiCond OpenCond;
        public byte OpenVal;
}
public unsafe partial struct ImGuiNextItemDataPtr
{
    public ImGuiNextItemData* NativePtr { get; }
    public ImGuiNextItemDataPtr(ImGuiNextItemData* nativePtr) => NativePtr = nativePtr;
    public ImGuiNextItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextItemData*)nativePtr;
    public static implicit operator ImGuiNextItemDataPtr(ImGuiNextItemData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiNextItemData* (ImGuiNextItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiNextItemDataPtr(IntPtr nativePtr) => new (nativePtr);
}
