// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTextBuffer
{
        public ImVector Buf;
}
public unsafe partial struct ImGuiTextBufferPtr
{
    public ImGuiTextBuffer* NativePtr { get; }
    public ImGuiTextBufferPtr(ImGuiTextBuffer* nativePtr) => NativePtr = nativePtr;
    public ImGuiTextBufferPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextBuffer*)nativePtr;
    public static implicit operator ImGuiTextBufferPtr(ImGuiTextBuffer* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTextBuffer* (ImGuiTextBufferPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTextBufferPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
//TODO Functions
}
