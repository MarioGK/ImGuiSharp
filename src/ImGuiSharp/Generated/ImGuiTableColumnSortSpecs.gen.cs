// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTableColumnSortSpecs
{
        public uint ColumnUserID;
        public short ColumnIndex;
        public short SortOrder;
        public ImGuiSortDirection SortDirection;
}
public unsafe partial struct ImGuiTableColumnSortSpecsPtr
{
    public ImGuiTableColumnSortSpecs* NativePtr { get; }
    public ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* nativePtr) => NativePtr = nativePtr;
    public ImGuiTableColumnSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSortSpecs*)nativePtr;
    public static implicit operator ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTableColumnSortSpecs* (ImGuiTableColumnSortSpecsPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTableColumnSortSpecsPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
