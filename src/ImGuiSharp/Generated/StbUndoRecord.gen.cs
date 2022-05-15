// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct StbUndoRecord
{
        public int Where;
        public int InsertLength;
        public int DeleteLength;
        public int CharStorage;
}
public unsafe partial struct StbUndoRecordPtr
{
    public StbUndoRecord* NativePtr { get; }
    public StbUndoRecordPtr(StbUndoRecord* nativePtr) => NativePtr = nativePtr;
    public StbUndoRecordPtr(IntPtr nativePtr) => NativePtr = (StbUndoRecord*)nativePtr;
    public static implicit operator StbUndoRecordPtr(StbUndoRecord* nativePtr) => new (nativePtr);
    public static implicit operator StbUndoRecord* (StbUndoRecordPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator StbUndoRecordPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
