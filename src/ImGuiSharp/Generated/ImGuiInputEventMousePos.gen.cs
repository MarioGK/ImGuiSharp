// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiInputEventMousePos
{
        public float PosX;
        public float PosY;
}
public unsafe partial struct ImGuiInputEventMousePosPtr
{
    public ImGuiInputEventMousePos* NativePtr { get; }
    public ImGuiInputEventMousePosPtr(ImGuiInputEventMousePos* nativePtr) => NativePtr = nativePtr;
    public ImGuiInputEventMousePosPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventMousePos*)nativePtr;
    public static implicit operator ImGuiInputEventMousePosPtr(ImGuiInputEventMousePos* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiInputEventMousePos* (ImGuiInputEventMousePosPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiInputEventMousePosPtr(IntPtr nativePtr) => new (nativePtr);
}
