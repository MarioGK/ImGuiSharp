// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiLastItemData
{
        public uint ID;
        public ImGuiItemFlags InFlags;
        public ImGuiItemStatusFlags StatusFlags;
        public ImRect Rect;
        public ImRect NavRect;
        public ImRect DisplayRect;
}
public unsafe partial struct ImGuiLastItemDataPtr
{
    public ImGuiLastItemData* NativePtr { get; }
    public ImGuiLastItemDataPtr(ImGuiLastItemData* nativePtr) => NativePtr = nativePtr;
    public ImGuiLastItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiLastItemData*)nativePtr;
    public static implicit operator ImGuiLastItemDataPtr(ImGuiLastItemData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiLastItemData* (ImGuiLastItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiLastItemDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
