// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiInputEvent
{
        public ImGuiInputEventType Type;
        public ImGuiInputSource Source;
        public byte AddedByTestEngine;
}
public unsafe partial struct ImGuiInputEventPtr
{
    public ImGuiInputEvent* NativePtr { get; }
    public ImGuiInputEventPtr(ImGuiInputEvent* nativePtr) => NativePtr = nativePtr;
    public ImGuiInputEventPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEvent*)nativePtr;
    public static implicit operator ImGuiInputEventPtr(ImGuiInputEvent* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiInputEvent* (ImGuiInputEventPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiInputEventPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
