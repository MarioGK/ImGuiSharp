// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiOnceUponAFrame
{
        public int RefFrame;
}
public unsafe partial struct ImGuiOnceUponAFramePtr
{
    public ImGuiOnceUponAFrame* NativePtr { get; }
    public ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* nativePtr) => NativePtr = nativePtr;
    public ImGuiOnceUponAFramePtr(IntPtr nativePtr) => NativePtr = (ImGuiOnceUponAFrame*)nativePtr;
    public static implicit operator ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiOnceUponAFrame* (ImGuiOnceUponAFramePtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiOnceUponAFramePtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
//TODO Functions
}
