// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawVert
{
        public Vector2 Pos;
        public Vector2 Uv;
        public uint Col;
}
public unsafe partial struct ImDrawVertPtr
{
    public ImDrawVert* NativePtr { get; }
    public ImDrawVertPtr(ImDrawVert* nativePtr) => NativePtr = nativePtr;
    public ImDrawVertPtr(IntPtr nativePtr) => NativePtr = (ImDrawVert*)nativePtr;
    public static implicit operator ImDrawVertPtr(ImDrawVert* nativePtr) => new (nativePtr);
    public static implicit operator ImDrawVert* (ImDrawVertPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImDrawVertPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
