// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiStorage
{
        public ImVector Data;
}
public unsafe partial struct ImGuiStoragePtr
{
    public ImGuiStorage* NativePtr { get; }
    public ImGuiStoragePtr(ImGuiStorage* nativePtr) => NativePtr = nativePtr;
    public ImGuiStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiStorage*)nativePtr;
    public static implicit operator ImGuiStoragePtr(ImGuiStorage* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiStorage* (ImGuiStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiStoragePtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
//TODO Functions
}
