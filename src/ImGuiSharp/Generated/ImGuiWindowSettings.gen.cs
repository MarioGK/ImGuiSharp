// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiWindowSettings
{
        public uint ID;
        public ImVec2ih Pos;
        public ImVec2ih Size;
        public byte Collapsed;
        public byte WantApply;
}
public unsafe partial struct ImGuiWindowSettingsPtr
{
    public ImGuiWindowSettings* NativePtr { get; }
    public ImGuiWindowSettingsPtr(ImGuiWindowSettings* nativePtr) => NativePtr = nativePtr;
    public ImGuiWindowSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowSettings*)nativePtr;
    public static implicit operator ImGuiWindowSettingsPtr(ImGuiWindowSettings* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiWindowSettings* (ImGuiWindowSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiWindowSettingsPtr(IntPtr nativePtr) => new (nativePtr);
}
