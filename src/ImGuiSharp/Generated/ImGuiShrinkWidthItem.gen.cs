// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiShrinkWidthItem
{
        public int Index;
        public float Width;
}
public unsafe partial struct ImGuiShrinkWidthItemPtr
{
    public ImGuiShrinkWidthItem* NativePtr { get; }
    public ImGuiShrinkWidthItemPtr(ImGuiShrinkWidthItem* nativePtr) => NativePtr = nativePtr;
    public ImGuiShrinkWidthItemPtr(IntPtr nativePtr) => NativePtr = (ImGuiShrinkWidthItem*)nativePtr;
    public static implicit operator ImGuiShrinkWidthItemPtr(ImGuiShrinkWidthItem* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiShrinkWidthItem* (ImGuiShrinkWidthItemPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiShrinkWidthItemPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
