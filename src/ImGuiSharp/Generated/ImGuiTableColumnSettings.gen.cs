// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTableColumnSettings
{
        public float WidthOrWeight;
        public uint UserID;
        public sbyte Index;
        public sbyte DisplayOrder;
        public sbyte SortOrder;
        public byte SortDirection;
        public byte IsEnabled;
        public byte IsStretch;
}
public unsafe partial struct ImGuiTableColumnSettingsPtr
{
    public ImGuiTableColumnSettings* NativePtr { get; }
    public ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => NativePtr = nativePtr;
    public ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSettings*)nativePtr;
    public static implicit operator ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTableColumnSettings* (ImGuiTableColumnSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => new (nativePtr);
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
