// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiKeyData
{
        public byte Down;
        public float DownDuration;
        public float DownDurationPrev;
        public float AnalogValue;
}
public unsafe partial struct ImGuiKeyDataPtr
{
    public ImGuiKeyData* NativePtr { get; }
    public ImGuiKeyDataPtr(ImGuiKeyData* nativePtr) => NativePtr = nativePtr;
    public ImGuiKeyDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyData*)nativePtr;
    public static implicit operator ImGuiKeyDataPtr(ImGuiKeyData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiKeyData* (ImGuiKeyDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiKeyDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
