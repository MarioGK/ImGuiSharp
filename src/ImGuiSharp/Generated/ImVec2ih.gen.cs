// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImVec2ih
{
        public short X;
        public short Y;
}
public unsafe partial struct ImVec2ihPtr
{
    public ImVec2ih* NativePtr { get; }
    public ImVec2ihPtr(ImVec2ih* nativePtr) => NativePtr = nativePtr;
    public ImVec2ihPtr(IntPtr nativePtr) => NativePtr = (ImVec2ih*)nativePtr;
    public static implicit operator ImVec2ihPtr(ImVec2ih* nativePtr) => new (nativePtr);
    public static implicit operator ImVec2ih* (ImVec2ihPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImVec2ihPtr(IntPtr nativePtr) => new (nativePtr);
}
