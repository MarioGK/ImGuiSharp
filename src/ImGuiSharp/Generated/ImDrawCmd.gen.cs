// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawCmd
{
        public Vector4 ClipRect;
        public IntPtr TextureId;
        public uint VtxOffset;
        public uint IdxOffset;
        public uint ElemCount;
        public IntPtr UserCallback;
        public void* UserCallbackData;
}
public unsafe partial struct ImDrawCmdPtr
{
    public ImDrawCmd* NativePtr { get; }
    public ImDrawCmdPtr(ImDrawCmd* nativePtr) => NativePtr = nativePtr;
    public ImDrawCmdPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmd*)nativePtr;
    public static implicit operator ImDrawCmdPtr(ImDrawCmd* nativePtr) => new (nativePtr);
    public static implicit operator ImDrawCmd* (ImDrawCmdPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImDrawCmdPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
