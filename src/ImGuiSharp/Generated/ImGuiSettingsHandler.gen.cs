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
public unsafe partial struct ImGuiSettingsHandlerPtr
{
    public ImGuiSettingsHandler* NativePtr { get; }
    public ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* nativePtr) => NativePtr = nativePtr;
    public ImGuiSettingsHandlerPtr(IntPtr nativePtr) => NativePtr = (ImGuiSettingsHandler*)nativePtr;
    public static implicit operator ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiSettingsHandler* (ImGuiSettingsHandlerPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiSettingsHandlerPtr(IntPtr nativePtr) => new (nativePtr);
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
