// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTextFilter
{
        public fixed byte InputBuf[256];
        public ImVector Filters;
        public int CountGrep;
}
public unsafe partial struct ImGuiTextFilterPtr
{
    public ImGuiTextFilter* NativePtr { get; }
    public ImGuiTextFilterPtr(ImGuiTextFilter* nativePtr) => NativePtr = nativePtr;
    public ImGuiTextFilterPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextFilter*)nativePtr;
    public static implicit operator ImGuiTextFilterPtr(ImGuiTextFilter* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTextFilter* (ImGuiTextFilterPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTextFilterPtr(IntPtr nativePtr) => new (nativePtr);
    public RangeAccessor<byte> InputBuf => new (NativePtr->InputBuf, 256);
}
