// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiSizeCallbackData
{
        public void* UserData;
        public Vector2 Pos;
        public Vector2 CurrentSize;
        public Vector2 DesiredSize;
}
public unsafe partial struct ImGuiSizeCallbackDataPtr
{
    public ImGuiSizeCallbackData* NativePtr { get; }
    public ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => NativePtr = nativePtr;
    public ImGuiSizeCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiSizeCallbackData*)nativePtr;
    public static implicit operator ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiSizeCallbackData* (ImGuiSizeCallbackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiSizeCallbackDataPtr(IntPtr nativePtr) => new (nativePtr);
}
