// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiStyle
{
        public float Alpha;
        public float DisabledAlpha;
        public Vector2 WindowPadding;
        public float WindowRounding;
        public float WindowBorderSize;
        public Vector2 WindowMinSize;
        public Vector2 WindowTitleAlign;
        public ImGuiDir WindowMenuButtonPosition;
        public float ChildRounding;
        public float ChildBorderSize;
        public float PopupRounding;
        public float PopupBorderSize;
        public Vector2 FramePadding;
        public float FrameRounding;
        public float FrameBorderSize;
        public Vector2 ItemSpacing;
        public Vector2 ItemInnerSpacing;
        public Vector2 CellPadding;
        public Vector2 TouchExtraPadding;
        public float IndentSpacing;
        public float ColumnsMinSpacing;
        public float ScrollbarSize;
        public float ScrollbarRounding;
        public float GrabMinSize;
        public float GrabRounding;
        public float LogSliderDeadzone;
        public float TabRounding;
        public float TabBorderSize;
        public float TabMinWidthForCloseButton;
        public ImGuiDir ColorButtonPosition;
        public Vector2 ButtonTextAlign;
        public Vector2 SelectableTextAlign;
        public Vector2 DisplayWindowPadding;
        public Vector2 DisplaySafeAreaPadding;
        public float MouseCursorScale;
        public byte AntiAliasedLines;
        public byte AntiAliasedLinesUseTex;
        public byte AntiAliasedFill;
        public float CurveTessellationTol;
        public float CircleTessellationMaxError;
        public Vector4 Colors0;
        public Vector4 Colors1;
        public Vector4 Colors2;
        public Vector4 Colors3;
        public Vector4 Colors4;
        public Vector4 Colors5;
        public Vector4 Colors6;
        public Vector4 Colors7;
        public Vector4 Colors8;
        public Vector4 Colors9;
        public Vector4 Colors10;
        public Vector4 Colors11;
        public Vector4 Colors12;
        public Vector4 Colors13;
        public Vector4 Colors14;
        public Vector4 Colors15;
        public Vector4 Colors16;
        public Vector4 Colors17;
        public Vector4 Colors18;
        public Vector4 Colors19;
        public Vector4 Colors20;
        public Vector4 Colors21;
        public Vector4 Colors22;
        public Vector4 Colors23;
        public Vector4 Colors24;
        public Vector4 Colors25;
        public Vector4 Colors26;
        public Vector4 Colors27;
        public Vector4 Colors28;
        public Vector4 Colors29;
        public Vector4 Colors30;
        public Vector4 Colors31;
        public Vector4 Colors32;
        public Vector4 Colors33;
        public Vector4 Colors34;
        public Vector4 Colors35;
        public Vector4 Colors36;
        public Vector4 Colors37;
        public Vector4 Colors38;
        public Vector4 Colors39;
        public Vector4 Colors40;
        public Vector4 Colors41;
        public Vector4 Colors42;
        public Vector4 Colors43;
        public Vector4 Colors44;
        public Vector4 Colors45;
        public Vector4 Colors46;
        public Vector4 Colors47;
        public Vector4 Colors48;
        public Vector4 Colors49;
        public Vector4 Colors50;
        public Vector4 Colors51;
        public Vector4 Colors52;
        public Vector4 Colors53;
}
public unsafe partial struct ImGuiStylePtr
{
    public ImGuiStyle* NativePtr { get; }
    public ImGuiStylePtr(ImGuiStyle* nativePtr) => NativePtr = nativePtr;
    public ImGuiStylePtr(IntPtr nativePtr) => NativePtr = (ImGuiStyle*)nativePtr;
    public static implicit operator ImGuiStylePtr(ImGuiStyle* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiStyle* (ImGuiStylePtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiStylePtr(IntPtr nativePtr) => new (nativePtr);
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
    public RangeAccessor<Vector4> Colors => new (&NativePtr->Colors0, 53);
//TODO Functions
}
