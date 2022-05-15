// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTableCellData
{
        public uint BgColor;
        public sbyte Column;
}
public unsafe partial struct ImGuiTableCellDataPtr
{
    public ImGuiTableCellData* NativePtr { get; }
    public ImGuiTableCellDataPtr(ImGuiTableCellData* nativePtr) => NativePtr = nativePtr;
    public ImGuiTableCellDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableCellData*)nativePtr;
    public static implicit operator ImGuiTableCellDataPtr(ImGuiTableCellData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTableCellData* (ImGuiTableCellDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTableCellDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
