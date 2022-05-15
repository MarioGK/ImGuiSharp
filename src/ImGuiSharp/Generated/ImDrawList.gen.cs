// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawList
{
        public ImVector CmdBuffer;
        public ImVector IdxBuffer;
        public ImVector VtxBuffer;
        public ImDrawListFlags Flags;
        public uint VtxCurrentIdx;
        public IntPtr Data;
        public byte* OwnerName;
        public ImDrawVert* VtxWritePtr;
        public ushort* IdxWritePtr;
        public ImVector ClipRectStack;
        public ImVector TextureIdStack;
        public ImVector Path;
        public ImDrawCmdHeader CmdHeader;
        public ImDrawListSplitter Splitter;
        public float FringeScale;
}
public unsafe partial struct ImDrawListPtr
{
    public ImDrawList* NativePtr { get; }
    public ImDrawListPtr(ImDrawList* nativePtr) => NativePtr = nativePtr;
    public ImDrawListPtr(IntPtr nativePtr) => NativePtr = (ImDrawList*)nativePtr;
    public static implicit operator ImDrawListPtr(ImDrawList* nativePtr) => new (nativePtr);
    public static implicit operator ImDrawList* (ImDrawListPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImDrawListPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
