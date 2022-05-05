// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiContextHook
{
        public uint HookId;
        public ImGuiContextHookType Type;
        public uint Owner;
        public IntPtr Callback;
        public void* UserData;
}
public unsafe partial struct ImGuiContextHookPtr
{
    public ImGuiContextHook* NativePtr { get; }
    public ImGuiContextHookPtr(ImGuiContextHook* nativePtr) => NativePtr = nativePtr;
    public ImGuiContextHookPtr(IntPtr nativePtr) => NativePtr = (ImGuiContextHook*)nativePtr;
    public static implicit operator ImGuiContextHookPtr(ImGuiContextHook* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiContextHook* (ImGuiContextHookPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiContextHookPtr(IntPtr nativePtr) => new (nativePtr);
}
