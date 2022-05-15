// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiInputEventMouseButton
{
        public int Button;
        public byte Down;
}
public unsafe partial struct ImGuiInputEventMouseButtonPtr
{
    public ImGuiInputEventMouseButton* NativePtr { get; }
    public ImGuiInputEventMouseButtonPtr(ImGuiInputEventMouseButton* nativePtr) => NativePtr = nativePtr;
    public ImGuiInputEventMouseButtonPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventMouseButton*)nativePtr;
    public static implicit operator ImGuiInputEventMouseButtonPtr(ImGuiInputEventMouseButton* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiInputEventMouseButton* (ImGuiInputEventMouseButtonPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiInputEventMouseButtonPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
