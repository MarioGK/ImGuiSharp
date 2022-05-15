// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiListClipper
{
        public int DisplayStart;
        public int DisplayEnd;
        public int ItemsCount;
        public float ItemsHeight;
        public float StartPosY;
        public void* TempData;
}
public unsafe partial struct ImGuiListClipperPtr
{
    public ImGuiListClipper* NativePtr { get; }
    public ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => NativePtr = nativePtr;
    public ImGuiListClipperPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipper*)nativePtr;
    public static implicit operator ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiListClipper* (ImGuiListClipperPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiListClipperPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
