// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImRect
{
        public Vector2 Min;
        public Vector2 Max;
}
public unsafe partial struct ImRectPtr
{
    public ImRect* NativePtr { get; }
    public ImRectPtr(ImRect* nativePtr) => NativePtr = nativePtr;
    public ImRectPtr(IntPtr nativePtr) => NativePtr = (ImRect*)nativePtr;
    public static implicit operator ImRectPtr(ImRect* nativePtr) => new (nativePtr);
    public static implicit operator ImRect* (ImRectPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImRectPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
