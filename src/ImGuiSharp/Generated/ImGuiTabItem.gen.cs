// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTabItem
{
        public uint ID;
        public ImGuiTabItemFlags Flags;
        public int LastFrameVisible;
        public int LastFrameSelected;
        public float Offset;
        public float Width;
        public float ContentWidth;
        public int NameOffset;
        public short BeginOrder;
        public short IndexDuringLayout;
        public byte WantClose;
}
public unsafe partial struct ImGuiTabItemPtr
{
    public ImGuiTabItem* NativePtr { get; }
    public ImGuiTabItemPtr(ImGuiTabItem* nativePtr) => NativePtr = nativePtr;
    public ImGuiTabItemPtr(IntPtr nativePtr) => NativePtr = (ImGuiTabItem*)nativePtr;
    public static implicit operator ImGuiTabItemPtr(ImGuiTabItem* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTabItem* (ImGuiTabItemPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTabItemPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
