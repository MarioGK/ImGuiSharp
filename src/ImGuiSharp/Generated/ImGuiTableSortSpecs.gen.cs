// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTableSortSpecs
{
        public ImGuiTableColumnSortSpecs* Specs;
        public int SpecsCount;
        public byte SpecsDirty;
}
public unsafe partial struct ImGuiTableSortSpecsPtr
{
    public ImGuiTableSortSpecs* NativePtr { get; }
    public ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* nativePtr) => NativePtr = nativePtr;
    public ImGuiTableSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSortSpecs*)nativePtr;
    public static implicit operator ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTableSortSpecs* (ImGuiTableSortSpecsPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTableSortSpecsPtr(IntPtr nativePtr) => new (nativePtr);
}
