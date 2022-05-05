// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiWindowTempData
{
        public Vector2 CursorPos;
        public Vector2 CursorPosPrevLine;
        public Vector2 CursorStartPos;
        public Vector2 CursorMaxPos;
        public Vector2 IdealMaxPos;
        public Vector2 CurrLineSize;
        public Vector2 PrevLineSize;
        public float CurrLineTextBaseOffset;
        public float PrevLineTextBaseOffset;
        public ImVec1 Indent;
        public ImVec1 ColumnsOffset;
        public ImVec1 GroupOffset;
        public Vector2 CursorStartPosLossyness;
        public ImGuiNavLayer NavLayerCurrent;
        public short NavLayersActiveMask;
        public short NavLayersActiveMaskNext;
        public uint NavFocusScopeIdCurrent;
        public byte NavHideHighlightOneFrame;
        public byte NavHasScroll;
        public byte MenuBarAppending;
        public Vector2 MenuBarOffset;
        public ImGuiMenuColumns MenuColumns;
        public int TreeDepth;
        public uint TreeJumpToParentOnPopMask;
        public ImVector ChildWindows;
        public ImGuiStorage* StateStorage;
        public ImGuiOldColumns* CurrentColumns;
        public int CurrentTableIdx;
        public ImGuiLayoutType LayoutType;
        public ImGuiLayoutType ParentLayoutType;
        public float ItemWidth;
        public float TextWrapPos;
        public ImVector ItemWidthStack;
        public ImVector TextWrapPosStack;
}
public unsafe partial struct ImGuiWindowTempDataPtr
{
    public ImGuiWindowTempData* NativePtr { get; }
    public ImGuiWindowTempDataPtr(ImGuiWindowTempData* nativePtr) => NativePtr = nativePtr;
    public ImGuiWindowTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowTempData*)nativePtr;
    public static implicit operator ImGuiWindowTempDataPtr(ImGuiWindowTempData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiWindowTempData* (ImGuiWindowTempDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiWindowTempDataPtr(IntPtr nativePtr) => new (nativePtr);
}
