// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawListSplitter
{
        public int Current;
        public int Count;
        public ImVector Channels;
}
public unsafe partial struct ImDrawListSplitterPtr
{
    public ImDrawListSplitter* NativePtr { get; }
    public ImDrawListSplitterPtr(ImDrawListSplitter* nativePtr) => NativePtr = nativePtr;
    public ImDrawListSplitterPtr(IntPtr nativePtr) => NativePtr = (ImDrawListSplitter*)nativePtr;
    public static implicit operator ImDrawListSplitterPtr(ImDrawListSplitter* nativePtr) => new (nativePtr);
    public static implicit operator ImDrawListSplitter* (ImDrawListSplitterPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImDrawListSplitterPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
