// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiDataTypeTempStorage
{
        public byte Data0;
        public byte Data1;
        public byte Data2;
        public byte Data3;
        public byte Data4;
        public byte Data5;
        public byte Data6;
        public byte Data7;
        public byte Data8;
}
public unsafe partial struct ImGuiDataTypeTempStoragePtr
{
    public ImGuiDataTypeTempStorage* NativePtr { get; }
    public ImGuiDataTypeTempStoragePtr(ImGuiDataTypeTempStorage* nativePtr) => NativePtr = nativePtr;
    public ImGuiDataTypeTempStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiDataTypeTempStorage*)nativePtr;
    public static implicit operator ImGuiDataTypeTempStoragePtr(ImGuiDataTypeTempStorage* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiDataTypeTempStorage* (ImGuiDataTypeTempStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiDataTypeTempStoragePtr(IntPtr nativePtr) => new (nativePtr);
    public RangeAccessor<byte> Data => new (&NativePtr->Data0, 8);
}
