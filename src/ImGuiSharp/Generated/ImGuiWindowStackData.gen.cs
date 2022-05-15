// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiWindowStackData
{
        public ImGuiWindow* Window;
        public ImGuiLastItemData ParentLastItemDataBackup;
        public ImGuiStackSizes StackSizesOnBegin;
}
public unsafe partial struct ImGuiWindowStackDataPtr
{
    public ImGuiWindowStackData* NativePtr { get; }
    public ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => NativePtr = nativePtr;
    public ImGuiWindowStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowStackData*)nativePtr;
    public static implicit operator ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiWindowStackData* (ImGuiWindowStackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiWindowStackDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
