// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawChannel
{
        public ImVector CmdBuffer;
        public ImVector IdxBuffer;
}
public unsafe partial struct ImDrawChannelPtr
{
    public ImDrawChannel* NativePtr { get; }
    public ImDrawChannelPtr(ImDrawChannel* nativePtr) => NativePtr = nativePtr;
    public ImDrawChannelPtr(IntPtr nativePtr) => NativePtr = (ImDrawChannel*)nativePtr;
    public static implicit operator ImDrawChannelPtr(ImDrawChannel* nativePtr) => new (nativePtr);
    public static implicit operator ImDrawChannel* (ImDrawChannelPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImDrawChannelPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
