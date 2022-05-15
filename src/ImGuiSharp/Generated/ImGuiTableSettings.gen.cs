// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTableSettings
{
        public uint ID;
        public ImGuiTableFlags SaveFlags;
        public float RefScale;
        public sbyte ColumnsCount;
        public sbyte ColumnsCountMax;
        public byte WantApply;
}
public unsafe partial struct ImGuiTableSettingsPtr
{
    public ImGuiTableSettings* NativePtr { get; }
    public ImGuiTableSettingsPtr(ImGuiTableSettings* nativePtr) => NativePtr = nativePtr;
    public ImGuiTableSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSettings*)nativePtr;
    public static implicit operator ImGuiTableSettingsPtr(ImGuiTableSettings* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTableSettings* (ImGuiTableSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTableSettingsPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
