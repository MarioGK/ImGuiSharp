// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiInputEventKey
{
        public ImGuiKey Key;
        public byte Down;
        public float AnalogValue;
}
public unsafe partial struct ImGuiInputEventKeyPtr
{
    public ImGuiInputEventKey* NativePtr { get; }
    public ImGuiInputEventKeyPtr(ImGuiInputEventKey* nativePtr) => NativePtr = nativePtr;
    public ImGuiInputEventKeyPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventKey*)nativePtr;
    public static implicit operator ImGuiInputEventKeyPtr(ImGuiInputEventKey* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiInputEventKey* (ImGuiInputEventKeyPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiInputEventKeyPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
