// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiColorMod
{
        public ImGuiCol Col;
        public Vector4 BackupValue;
}
public unsafe partial struct ImGuiColorModPtr
{
    public ImGuiColorMod* NativePtr { get; }
    public ImGuiColorModPtr(ImGuiColorMod* nativePtr) => NativePtr = nativePtr;
    public ImGuiColorModPtr(IntPtr nativePtr) => NativePtr = (ImGuiColorMod*)nativePtr;
    public static implicit operator ImGuiColorModPtr(ImGuiColorMod* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiColorMod* (ImGuiColorModPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiColorModPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
