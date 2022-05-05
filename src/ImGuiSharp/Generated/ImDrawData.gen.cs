// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawData
{
        public byte Valid;
        public int CmdListsCount;
        public int TotalIdxCount;
        public int TotalVtxCount;
        public ImDrawList** CmdLists;
        public Vector2 DisplayPos;
        public Vector2 DisplaySize;
        public Vector2 FramebufferScale;
}
public unsafe partial struct ImDrawDataPtr
{
    public ImDrawData* NativePtr { get; }
    public ImDrawDataPtr(ImDrawData* nativePtr) => NativePtr = nativePtr;
    public ImDrawDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawData*)nativePtr;
    public static implicit operator ImDrawDataPtr(ImDrawData* nativePtr) => new (nativePtr);
    public static implicit operator ImDrawData* (ImDrawDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImDrawDataPtr(IntPtr nativePtr) => new (nativePtr);
}
