// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiInputEventText
{
        public uint Char;
}
public unsafe partial struct ImGuiInputEventTextPtr
{
    public ImGuiInputEventText* NativePtr { get; }
    public ImGuiInputEventTextPtr(ImGuiInputEventText* nativePtr) => NativePtr = nativePtr;
    public ImGuiInputEventTextPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventText*)nativePtr;
    public static implicit operator ImGuiInputEventTextPtr(ImGuiInputEventText* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiInputEventText* (ImGuiInputEventTextPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiInputEventTextPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
//TODO Functions
}
