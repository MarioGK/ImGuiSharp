// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiViewportP
{
        public ImGuiViewport ImGuiViewport;
        public fixed int DrawListsLastFrame[2];
        public ImDrawList* DrawLists0;
        public ImDrawList* DrawLists1;
        public ImDrawList* DrawLists2;
        public ImDrawData DrawDataP;
        public ImDrawDataBuilder DrawDataBuilder;
        public Vector2 WorkOffsetMin;
        public Vector2 WorkOffsetMax;
        public Vector2 BuildWorkOffsetMin;
        public Vector2 BuildWorkOffsetMax;
}
public unsafe partial struct ImGuiViewportPPtr
{
    public ImGuiViewportP* NativePtr { get; }
    public ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => NativePtr = nativePtr;
    public ImGuiViewportPPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewportP*)nativePtr;
    public static implicit operator ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiViewportP* (ImGuiViewportPPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiViewportPPtr(IntPtr nativePtr) => new (nativePtr);
    public RangeAccessor<int> DrawListsLastFrame => new (NativePtr->DrawListsLastFrame, 2);
    public RangeAccessor<ImDrawList> DrawLists => new (&NativePtr->DrawLists0, 2);
}
