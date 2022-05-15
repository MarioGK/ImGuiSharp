// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiPlatformImeData
{
        public byte WantVisible;
        public Vector2 InputPos;
        public float InputLineHeight;
}
public unsafe partial struct ImGuiPlatformImeDataPtr
{
    public ImGuiPlatformImeData* NativePtr { get; }
    public ImGuiPlatformImeDataPtr(ImGuiPlatformImeData* nativePtr) => NativePtr = nativePtr;
    public ImGuiPlatformImeDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformImeData*)nativePtr;
    public static implicit operator ImGuiPlatformImeDataPtr(ImGuiPlatformImeData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiPlatformImeData* (ImGuiPlatformImeDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiPlatformImeDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
