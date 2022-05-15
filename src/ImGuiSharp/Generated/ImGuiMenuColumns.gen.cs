// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiMenuColumns
{
        public uint TotalWidth;
        public uint NextTotalWidth;
        public ushort Spacing;
        public ushort OffsetIcon;
        public ushort OffsetLabel;
        public ushort OffsetShortcut;
        public ushort OffsetMark;
        public ushort Widths0;
        public ushort Widths1;
        public ushort Widths2;
        public ushort Widths3;
        public ushort Widths4;
}
public unsafe partial struct ImGuiMenuColumnsPtr
{
    public ImGuiMenuColumns* NativePtr { get; }
    public ImGuiMenuColumnsPtr(ImGuiMenuColumns* nativePtr) => NativePtr = nativePtr;
    public ImGuiMenuColumnsPtr(IntPtr nativePtr) => NativePtr = (ImGuiMenuColumns*)nativePtr;
    public static implicit operator ImGuiMenuColumnsPtr(ImGuiMenuColumns* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiMenuColumns* (ImGuiMenuColumnsPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiMenuColumnsPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    public RangeAccessor<ushort> Widths => new (&NativePtr->Widths0, 4);
//TODO Functions
}
