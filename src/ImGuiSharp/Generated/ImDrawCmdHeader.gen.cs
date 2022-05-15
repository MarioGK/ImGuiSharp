// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawCmdHeader
{
        public Vector4 ClipRect;
        public IntPtr TextureId;
        public uint VtxOffset;
}
public unsafe partial struct ImDrawCmdHeaderPtr
{
    public ImDrawCmdHeader* NativePtr { get; }
    public ImDrawCmdHeaderPtr(ImDrawCmdHeader* nativePtr) => NativePtr = nativePtr;
    public ImDrawCmdHeaderPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmdHeader*)nativePtr;
    public static implicit operator ImDrawCmdHeaderPtr(ImDrawCmdHeader* nativePtr) => new (nativePtr);
    public static implicit operator ImDrawCmdHeader* (ImDrawCmdHeaderPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImDrawCmdHeaderPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
