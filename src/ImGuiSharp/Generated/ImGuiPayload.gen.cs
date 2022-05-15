// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiPayload
{
        public void* Data;
        public int DataSize;
        public uint SourceId;
        public uint SourceParentId;
        public int DataFrameCount;
        public fixed byte DataType[33];
        public byte Preview;
        public byte Delivery;
}
public unsafe partial struct ImGuiPayloadPtr
{
    public ImGuiPayload* NativePtr { get; }
    public ImGuiPayloadPtr(ImGuiPayload* nativePtr) => NativePtr = nativePtr;
    public ImGuiPayloadPtr(IntPtr nativePtr) => NativePtr = (ImGuiPayload*)nativePtr;
    public static implicit operator ImGuiPayloadPtr(ImGuiPayload* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiPayload* (ImGuiPayloadPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiPayloadPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    public RangeAccessor<byte> DataType => new (NativePtr->DataType, 33);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
