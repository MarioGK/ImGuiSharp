// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiNextWindowData
{
        public ImGuiNextWindowDataFlags Flags;
        public ImGuiCond PosCond;
        public ImGuiCond SizeCond;
        public ImGuiCond CollapsedCond;
        public Vector2 PosVal;
        public Vector2 PosPivotVal;
        public Vector2 SizeVal;
        public Vector2 ContentSizeVal;
        public Vector2 ScrollVal;
        public byte CollapsedVal;
        public ImRect SizeConstraintRect;
        public IntPtr SizeCallback;
        public void* SizeCallbackUserData;
        public float BgAlphaVal;
        public Vector2 MenuBarOffsetMinVal;
}
public unsafe partial struct ImGuiNextWindowDataPtr
{
    public ImGuiNextWindowData* NativePtr { get; }
    public ImGuiNextWindowDataPtr(ImGuiNextWindowData* nativePtr) => NativePtr = nativePtr;
    public ImGuiNextWindowDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextWindowData*)nativePtr;
    public static implicit operator ImGuiNextWindowDataPtr(ImGuiNextWindowData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiNextWindowData* (ImGuiNextWindowDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiNextWindowDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
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
