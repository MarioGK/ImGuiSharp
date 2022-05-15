// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImColor
{
        public Vector4 Value;
}
public unsafe partial struct ImColorPtr
{
    public ImColor* NativePtr { get; }
    public ImColorPtr(ImColor* nativePtr) => NativePtr = nativePtr;
    public ImColorPtr(IntPtr nativePtr) => NativePtr = (ImColor*)nativePtr;
    public static implicit operator ImColorPtr(ImColor* nativePtr) => new (nativePtr);
    public static implicit operator ImColor* (ImColorPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImColorPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
//TODO Functions
}
