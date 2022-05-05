// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiSettingsHandler
{
        public byte* TypeName;
        public uint TypeHash;
        public IntPtr ClearAllFn;
        public IntPtr ReadInitFn;
        public IntPtr ReadOpenFn;
        public IntPtr ReadLineFn;
        public IntPtr ApplyAllFn;
        public IntPtr WriteAllFn;
        public void* UserData;
}
