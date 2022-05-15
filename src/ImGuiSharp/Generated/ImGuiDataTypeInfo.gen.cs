// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiDataTypeInfo
{
        public uint Size;
        public byte* Name;
        public byte* PrintFmt;
        public byte* ScanFmt;
}
public unsafe partial struct ImGuiDataTypeInfoPtr
{
    public ImGuiDataTypeInfo* NativePtr { get; }
    public ImGuiDataTypeInfoPtr(ImGuiDataTypeInfo* nativePtr) => NativePtr = nativePtr;
    public ImGuiDataTypeInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiDataTypeInfo*)nativePtr;
    public static implicit operator ImGuiDataTypeInfoPtr(ImGuiDataTypeInfo* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiDataTypeInfo* (ImGuiDataTypeInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiDataTypeInfoPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
