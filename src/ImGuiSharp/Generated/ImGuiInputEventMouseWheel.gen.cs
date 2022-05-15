// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiInputEventMouseWheel
{
        public float WheelX;
        public float WheelY;
}
public unsafe partial struct ImGuiInputEventMouseWheelPtr
{
    public ImGuiInputEventMouseWheel* NativePtr { get; }
    public ImGuiInputEventMouseWheelPtr(ImGuiInputEventMouseWheel* nativePtr) => NativePtr = nativePtr;
    public ImGuiInputEventMouseWheelPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventMouseWheel*)nativePtr;
    public static implicit operator ImGuiInputEventMouseWheelPtr(ImGuiInputEventMouseWheel* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiInputEventMouseWheel* (ImGuiInputEventMouseWheelPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiInputEventMouseWheelPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
