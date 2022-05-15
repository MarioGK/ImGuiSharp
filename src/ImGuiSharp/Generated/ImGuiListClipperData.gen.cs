// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiListClipperData
{
        public ImGuiListClipper* ListClipper;
        public float LossynessOffset;
        public int StepNo;
        public int ItemsFrozen;
        public ImVector Ranges;
}
public unsafe partial struct ImGuiListClipperDataPtr
{
    public ImGuiListClipperData* NativePtr { get; }
    public ImGuiListClipperDataPtr(ImGuiListClipperData* nativePtr) => NativePtr = nativePtr;
    public ImGuiListClipperDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipperData*)nativePtr;
    public static implicit operator ImGuiListClipperDataPtr(ImGuiListClipperData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiListClipperData* (ImGuiListClipperDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiListClipperDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
