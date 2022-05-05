// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiInputEventAppFocused
{
        public byte Focused;
}
public unsafe partial struct ImGuiInputEventAppFocusedPtr
{
    public ImGuiInputEventAppFocused* NativePtr { get; }
    public ImGuiInputEventAppFocusedPtr(ImGuiInputEventAppFocused* nativePtr) => NativePtr = nativePtr;
    public ImGuiInputEventAppFocusedPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventAppFocused*)nativePtr;
    public static implicit operator ImGuiInputEventAppFocusedPtr(ImGuiInputEventAppFocused* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiInputEventAppFocused* (ImGuiInputEventAppFocusedPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiInputEventAppFocusedPtr(IntPtr nativePtr) => new (nativePtr);
}
