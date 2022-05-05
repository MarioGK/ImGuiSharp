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
