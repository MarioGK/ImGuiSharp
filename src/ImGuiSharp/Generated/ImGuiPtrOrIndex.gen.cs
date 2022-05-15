// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiPtrOrIndex
{
        public void* Ptr;
        public int Index;
}
public unsafe partial struct ImGuiPtrOrIndexPtr
{
    public ImGuiPtrOrIndex* NativePtr { get; }
    public ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* nativePtr) => NativePtr = nativePtr;
    public ImGuiPtrOrIndexPtr(IntPtr nativePtr) => NativePtr = (ImGuiPtrOrIndex*)nativePtr;
    public static implicit operator ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiPtrOrIndex* (ImGuiPtrOrIndexPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiPtrOrIndexPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
