// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiStackTool
{
        public int LastActiveFrame;
        public int StackLevel;
        public uint QueryId;
        public ImVector Results;
}
public unsafe partial struct ImGuiStackToolPtr
{
    public ImGuiStackTool* NativePtr { get; }
    public ImGuiStackToolPtr(ImGuiStackTool* nativePtr) => NativePtr = nativePtr;
    public ImGuiStackToolPtr(IntPtr nativePtr) => NativePtr = (ImGuiStackTool*)nativePtr;
    public static implicit operator ImGuiStackToolPtr(ImGuiStackTool* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiStackTool* (ImGuiStackToolPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiStackToolPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
