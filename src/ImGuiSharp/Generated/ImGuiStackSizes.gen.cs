// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiStackSizes
{
        public short SizeOfIDStack;
        public short SizeOfColorStack;
        public short SizeOfStyleVarStack;
        public short SizeOfFontStack;
        public short SizeOfFocusScopeStack;
        public short SizeOfGroupStack;
        public short SizeOfItemFlagsStack;
        public short SizeOfBeginPopupStack;
        public short SizeOfDisabledStack;
}
public unsafe partial struct ImGuiStackSizesPtr
{
    public ImGuiStackSizes* NativePtr { get; }
    public ImGuiStackSizesPtr(ImGuiStackSizes* nativePtr) => NativePtr = nativePtr;
    public ImGuiStackSizesPtr(IntPtr nativePtr) => NativePtr = (ImGuiStackSizes*)nativePtr;
    public static implicit operator ImGuiStackSizesPtr(ImGuiStackSizes* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiStackSizes* (ImGuiStackSizesPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiStackSizesPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
