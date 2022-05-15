// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiViewport
{
        public ImGuiViewportFlags Flags;
        public Vector2 Pos;
        public Vector2 Size;
        public Vector2 WorkPos;
        public Vector2 WorkSize;
        public void* PlatformHandleRaw;
}
public unsafe partial struct ImGuiViewportPtr
{
    public ImGuiViewport* NativePtr { get; }
    public ImGuiViewportPtr(ImGuiViewport* nativePtr) => NativePtr = nativePtr;
    public ImGuiViewportPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewport*)nativePtr;
    public static implicit operator ImGuiViewportPtr(ImGuiViewport* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiViewport* (ImGuiViewportPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiViewportPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
