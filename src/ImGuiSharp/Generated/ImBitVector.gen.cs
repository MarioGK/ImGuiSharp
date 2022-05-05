// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImBitVector
{
        public ImVector Storage;
}
public unsafe partial struct ImBitVectorPtr
{
    public ImBitVector* NativePtr { get; }
    public ImBitVectorPtr(ImBitVector* nativePtr) => NativePtr = nativePtr;
    public ImBitVectorPtr(IntPtr nativePtr) => NativePtr = (ImBitVector*)nativePtr;
    public static implicit operator ImBitVectorPtr(ImBitVector* nativePtr) => new (nativePtr);
    public static implicit operator ImBitVector* (ImBitVectorPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImBitVectorPtr(IntPtr nativePtr) => new (nativePtr);
}
