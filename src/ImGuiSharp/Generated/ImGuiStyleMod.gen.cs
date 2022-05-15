// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiStyleMod
{
        public ImGuiStyleVar VarIdx;
}
public unsafe partial struct ImGuiStyleModPtr
{
    public ImGuiStyleMod* NativePtr { get; }
    public ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => NativePtr = nativePtr;
    public ImGuiStyleModPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleMod*)nativePtr;
    public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiStyleMod* (ImGuiStyleModPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiStyleModPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
//TODO Functions
}
