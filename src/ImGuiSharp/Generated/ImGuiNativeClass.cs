// ReSharper disable once CheckNamespace
namespace ImGui;
public static unsafe partial class ImGuiNative
{
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitArray_ClearAllBits();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitArray_ClearBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitArray_SetAllBits();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitArray_SetBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitArray_SetBitRange();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImBitArray_TestBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitArray_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitVector_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitVector_ClearBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitVector_Create();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitVector_SetBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImBitVector_TestBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImColor_HSV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImColor_SetHSV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImColor_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr ImDrawCmd_GetTexID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawCmd_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawDataBuilder_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawDataBuilder_ClearFreeMemory();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawDataBuilder_FlattenIntoSingleLayer();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImDrawDataBuilder_GetDrawListCount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawData_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawData_DeIndexAllBuffers();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawData_ScaleClipRects();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawListSharedData_SetCircleTessellationMaxError();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawListSharedData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawListSplitter_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawListSplitter_ClearFreeMemory();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawListSplitter_Merge();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawListSplitter_SetCurrentChannel();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawListSplitter_Split();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawListSplitter_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddBezierCubic();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddBezierQuadratic();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddCallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddCircle();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddCircleFilled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddConvexPolyFilled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddDrawCmd();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddImage();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddImageQuad();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddImageRounded();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddLine();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddNgon();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddNgonFilled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddPolyline();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddQuad();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddQuadFilled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddRectFilled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddRectFilledMultiColor();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddText_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddText_FontPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddTriangle();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_AddTriangleFilled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_ChannelsMerge();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_ChannelsSetCurrent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_ChannelsSplit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImDrawList* ImDrawList_CloneOutput();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_GetClipRectMax();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_GetClipRectMin();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathArcTo();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathArcToFast();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathBezierCubicCurveTo();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathBezierQuadraticCurveTo();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathClear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathFillConvex();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathLineTo();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathLineToMergeDuplicate();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PathStroke();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PopClipRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PopTextureID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PrimQuadUV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PrimRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PrimRectUV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PrimReserve();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PrimUnreserve();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PrimVtx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PrimWriteIdx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PrimWriteVtx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PushClipRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PushClipRectFullScreen();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_PushTextureID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImDrawList__CalcCircleAutoSegmentCount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList__ClearFreeMemory();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList__OnChangedClipRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList__OnChangedTextureID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList__OnChangedVtxOffset();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList__PathArcToFastEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList__PathArcToN();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList__PopUnusedDrawCmd();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList__ResetForNewFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList__TryMergeDrawCmds();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImDrawList_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImFontAtlasCustomRect_IsPacked();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlasCustomRect_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImFontAtlas_AddCustomRectFontGlyph();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImFontAtlas_AddCustomRectRegular();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFont* ImFontAtlas_AddFont();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFont* ImFontAtlas_AddFontDefault();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFont* ImFontAtlas_AddFontFromFileTTF();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImFontAtlas_Build();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlas_CalcCustomRectUV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlas_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlas_ClearFonts();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlas_ClearInputData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlas_ClearTexData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort* ImFontAtlas_GetGlyphRangesDefault();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort* ImFontAtlas_GetGlyphRangesKorean();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort* ImFontAtlas_GetGlyphRangesThai();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImFontAtlas_GetMouseCursorTexData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlas_GetTexDataAsAlpha8();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlas_GetTexDataAsRGBA32();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImFontAtlas_IsBuilt();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlas_SetTexID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlas_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontConfig_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontGlyphRangesBuilder_AddChar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontGlyphRangesBuilder_AddRanges();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontGlyphRangesBuilder_AddText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontGlyphRangesBuilder_BuildRanges();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontGlyphRangesBuilder_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImFontGlyphRangesBuilder_GetBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontGlyphRangesBuilder_SetBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontGlyphRangesBuilder_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_AddGlyph();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_AddRemapChar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_BuildLookupTable();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_CalcTextSizeA();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImFont_CalcWordWrapPositionA();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_ClearOutputData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFontGlyph* ImFont_FindGlyph();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFontGlyph* ImFont_FindGlyphNoFallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImFont_GetCharAdvance();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImFont_GetDebugName();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_GrowIndex();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImFont_IsGlyphRangeUnused();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImFont_IsLoaded();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_RenderChar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_RenderText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_SetGlyphVisible();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFont_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiComboPreviewData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiContextHook_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiContext_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_AddFocusEvent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_AddInputCharacter();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_AddInputCharacterUTF16();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_AddInputCharactersUTF8();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_AddKeyAnalogEvent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_AddKeyEvent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_AddMouseButtonEvent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_AddMousePosEvent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_AddMouseWheelEvent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_ClearInputCharacters();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_ClearInputKeys();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_SetKeyEventNativeData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiIO_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputEvent_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextCallbackData_ClearSelection();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextCallbackData_DeleteChars();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiInputTextCallbackData_HasSelection();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextCallbackData_InsertChars();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextCallbackData_SelectAll();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextCallbackData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextState_ClearFreeMemory();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextState_ClearSelection();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextState_ClearText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextState_CursorAnimReset();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextState_CursorClamp();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImGuiInputTextState_GetCursorPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImGuiInputTextState_GetRedoAvailCount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImGuiInputTextState_GetSelectionEnd();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImGuiInputTextState_GetSelectionStart();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImGuiInputTextState_GetUndoAvailCount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiInputTextState_HasSelection();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextState_OnKeyPressed();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextState_SelectAll();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiInputTextState_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiLastItemData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiListClipperData_Reset();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiListClipperData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiListClipperRange ImGuiListClipperRange_FromIndices();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiListClipperRange ImGuiListClipperRange_FromPositions();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiListClipper_Begin();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiListClipper_End();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiListClipper_ForceDisplayRangeByIndices();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiListClipper_Step();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiListClipper_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiMenuColumns_CalcNextTotalWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImGuiMenuColumns_DeclColumns();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiMenuColumns_Update();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiMenuColumns_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiMetricsConfig_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiNavItemData_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiNavItemData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiNextItemData_ClearFlags();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiNextItemData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiNextWindowData_ClearFlags();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiNextWindowData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiOldColumnData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiOldColumns_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiOnceUponAFrame_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiPayload_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiPayload_IsDataType();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiPayload_IsDelivery();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiPayload_IsPreview();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiPayload_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiPlatformImeData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiPopupData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiPtrOrIndex_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiSettingsHandler_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStackLevelInfo_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStackSizes_CompareWithCurrentState();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStackSizes_SetToCurrentState();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStackSizes_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStackTool_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStoragePair_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStorage_BuildSortByKey();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStorage_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiStorage_GetBool();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImGuiStorage_GetBoolRef();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImGuiStorage_GetFloat();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float* ImGuiStorage_GetFloatRef();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImGuiStorage_GetInt();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int* ImGuiStorage_GetIntRef();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr ImGuiStorage_GetVoidPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void** ImGuiStorage_GetVoidPtrRef();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStorage_SetAllInt();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStorage_SetBool();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStorage_SetFloat();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStorage_SetInt();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStorage_SetVoidPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStyleMod_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStyle_ScaleAllSizes();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiStyle_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImGuiTabBar_GetTabName();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImGuiTabBar_GetTabOrder();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTabBar_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTabItem_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTableColumnSettings_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTableColumnSortSpecs_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTableColumn_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTableSettings_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTableSortSpecs_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTableTempData_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTable_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextBuffer_append();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextBuffer_appendf();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextBuffer_appendfv();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImGuiTextBuffer_begin();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImGuiTextBuffer_c_str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextBuffer_clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextBuffer_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiTextBuffer_empty();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImGuiTextBuffer_end();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextBuffer_reserve();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImGuiTextBuffer_size();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextFilter_Build();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextFilter_Clear();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiTextFilter_Draw();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiTextFilter_IsActive();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiTextFilter_PassFilter();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextFilter_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextRange_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGuiTextRange_empty();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiTextRange_split();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewportP_CalcWorkRectPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewportP_CalcWorkRectSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewportP_GetBuildWorkRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewportP_GetMainRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewportP_GetWorkRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewportP_UpdateWorkRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewportP_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewport_GetCenter();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewport_GetWorkCenter();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiViewport_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern string ImGuiWindowSettings_GetName();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiWindowSettings_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImGuiWindow_CalcFontSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImGuiWindow_GetID_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImGuiWindow_GetID_Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImGuiWindow_GetID_Int();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImGuiWindow_GetIDFromRectangle();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImGuiWindow_GetIDNoKeepAlive_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImGuiWindow_GetIDNoKeepAlive_Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImGuiWindow_GetIDNoKeepAlive_Int();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImGuiWindow_MenuBarHeight();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiWindow_MenuBarRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiWindow_Rect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImGuiWindow_TitleBarHeight();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiWindow_TitleBarRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGuiWindow_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_Add_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_Add_Rect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_ClipWith();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_ClipWithFull();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImRect_Contains_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImRect_Contains_Rect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_Expand_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_Expand_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_Floor();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImRect_GetArea();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_GetBL();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_GetBR();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_GetCenter();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImRect_GetHeight();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_GetSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_GetTL();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_GetTR();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImRect_GetWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImRect_IsInverted();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImRect_Overlaps();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_ToVec4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_Translate();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_TranslateX();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_TranslateY();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRect_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImSpanAllocator_GetArenaSizeInBytes();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr ImSpanAllocator_GetSpanPtrBegin();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr ImSpanAllocator_GetSpanPtrEnd();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImSpanAllocator_Reserve();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImSpanAllocator_SetArenaBasePtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImSpanAllocator_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImVec1_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImVec2_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImVec2ih_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImVec4_destroy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiPayload* AcceptDragDropPayload();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ActivateItem();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint AddContextHook();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void AlignTextToFramePadding();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ArrowButton();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ArrowButtonEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool Begin();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginChild_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginChild_ID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginChildEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginChildFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BeginColumns();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginCombo();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginComboPopup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginComboPreview();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BeginDisabled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginDragDropSource();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginDragDropTarget();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginDragDropTargetCustom();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BeginGroup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginListBox();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginMainMenuBar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginMenu();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginMenuBar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginMenuEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginPopup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginPopupContextItem();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginPopupContextVoid();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginPopupContextWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginPopupEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginPopupModal();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginTabBar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginTabBarEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginTabItem();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginTable();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginTableEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BeginTooltip();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BeginTooltipEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool BeginViewportSideBar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BringWindowToDisplayBack();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BringWindowToDisplayBehind();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BringWindowToDisplayFront();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BringWindowToFocusFront();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Bullet();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BulletText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void BulletTextV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool Button();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ButtonBehavior();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ButtonEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void CalcItemSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float CalcItemWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void CalcTextSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int CalcTypematicRepeatAmount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void CalcWindowNextAutoFitSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float CalcWrapWidthForPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void CallContextHooks();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void CaptureKeyboardFromApp();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void CaptureMouseFromApp();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool Checkbox();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CheckboxFlags_IntPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CheckboxFlags_UintPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CheckboxFlags_S64Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CheckboxFlags_U64Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ClearActiveID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ClearDragDrop();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ClearIniSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CloseButton();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void CloseCurrentPopup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ClosePopupToLevel();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ClosePopupsExceptModals();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ClosePopupsOverWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CollapseButton();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CollapsingHeader_TreeNodeFlags();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool CollapsingHeader_BoolPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ColorButton();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ColorConvertFloat4ToU32();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ColorConvertHSVtoRGB();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ColorConvertRGBtoHSV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ColorConvertU32ToFloat4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ColorEdit3();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ColorEdit4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ColorEditOptionsPopup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ColorPicker3();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ColorPicker4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ColorPickerOptionsPopup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ColorTooltip();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Columns();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool Combo_Str_arr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool Combo_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr CreateContext();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindowSettings* CreateNewWindowSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DataTypeApplyFromText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DataTypeApplyOp();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DataTypeClamp();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int DataTypeCompare();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int DataTypeFormatString();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiDataTypeInfo* DataTypeGetInfo();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DebugCheckVersionAndDataLayout();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugDrawItemRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugHookIdInfo();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeColumns();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeDrawCmdShowMeshAndBoundingBox();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeDrawList();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeFont();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeStorage();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeTabBar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeTable();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeTableSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeViewport();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeWindowSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeWindowsList();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugNodeWindowsListByBeginStackParent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugRenderViewportThumbnail();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DebugStartItemPicker();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void DestroyContext();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragBehavior();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragFloat();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragFloat2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragFloat3();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragFloat4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragFloatRange2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragInt();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragInt2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragInt3();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragInt4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragIntRange2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragScalar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool DragScalarN();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Dummy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void End();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndChild();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndChildFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndColumns();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndCombo();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndComboPreview();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndDisabled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndDragDropSource();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndDragDropTarget();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndGroup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndListBox();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndMainMenuBar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndMenu();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndMenuBar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndPopup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndTabBar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndTabItem();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndTable();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void EndTooltip();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ErrorCheckEndFrameRecover();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ErrorCheckEndWindowRecover();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void FindBestWindowPosForPopup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void FindBestWindowPosForPopupEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindow* FindBottomMostVisibleWindowWithinBeginStack();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiOldColumns* FindOrCreateColumns();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindowSettings* FindOrCreateWindowSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* FindRenderedTextEnd();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiSettingsHandler* FindSettingsHandler();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindow* FindWindowByID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindow* FindWindowByName();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int FindWindowDisplayIndex();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindowSettings* FindWindowSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void FocusTopMostWindowUnderOne();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void FocusWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GcAwakeTransientWindowBuffers();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GcCompactTransientMiscBuffers();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GcCompactTransientWindowBuffers();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetActiveID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetAllocatorFunctions();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImDrawList* GetBackgroundDrawList_Nil();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImDrawList* GetBackgroundDrawList_ViewportPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* GetClipboardText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetColorU32_Col();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetColorU32_Vec4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetColorU32_U32();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetColumnIndex();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetColumnNormFromOffset();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetColumnOffset();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetColumnOffsetFromNorm();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetColumnWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetColumnsCount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetColumnsID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetContentRegionAvail();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetContentRegionMax();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetContentRegionMaxAbs();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr GetCurrentContext();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiTable* GetCurrentTable();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindow* GetCurrentWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindow* GetCurrentWindowRead();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetCursorPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetCursorPosX();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetCursorPosY();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetCursorScreenPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetCursorStartPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFont* GetDefaultFont();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiPayload* GetDragDropPayload();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImDrawData* GetDrawData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr GetDrawListSharedData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetFocusID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetFocusScope();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetFocusedFocusScope();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImFont* GetFont();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetFontSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetFontTexUvWhitePixel();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImDrawList* GetForegroundDrawList_Nil();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImDrawList* GetForegroundDrawList_WindowPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImDrawList* GetForegroundDrawList_ViewportPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetFrameCount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetFrameHeight();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetFrameHeightWithSpacing();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetHoveredID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetID_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetID_StrStr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetID_Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetIDWithSeed();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiIO* GetIO();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiInputTextState* GetInputTextState();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiItemFlags GetItemFlags();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetItemID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetItemRectMax();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetItemRectMin();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetItemRectSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiItemStatusFlags GetItemStatusFlags();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiKeyData* GetKeyData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetKeyIndex();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* GetKeyName();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetKeyPressedAmount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiViewport* GetMainViewport();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiKeyModFlags GetMergedKeyModFlags();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int GetMouseClickedCount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiMouseCursor GetMouseCursor();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetMouseDragDelta();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetMousePos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetMousePosOnOpeningCurrentPopup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetNavInputAmount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetNavInputAmount2d();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* GetNavInputName();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetPopupAllowedExtentRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetScrollMaxX();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetScrollMaxY();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetScrollX();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetScrollY();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiStorage* GetStateStorage();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiStyle* GetStyle();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* GetStyleColorName();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern Vector4* GetStyleColorVec4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetTextLineHeight();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetTextLineHeightWithSpacing();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern double GetTime();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindow* GetTopMostAndVisiblePopupModal();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiWindow* GetTopMostPopupModal();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetTreeNodeToLabelSpacing();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* GetVersion();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetWindowContentRegionMax();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetWindowContentRegionMin();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImDrawList* GetWindowDrawList();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetWindowHeight();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetWindowPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetWindowResizeBorderID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetWindowResizeCornerID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint GetWindowScrollbarID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetWindowScrollbarRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void GetWindowSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float GetWindowWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImAbs_Int();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImAbs_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern double ImAbs_double();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImAlphaBlendColors();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBezierCubicCalc();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBezierCubicClosestPoint();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBezierCubicClosestPointCasteljau();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBezierQuadraticCalc();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitArrayClearBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitArraySetBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImBitArraySetBitRange();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImBitArrayTestBit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImCharIsBlankA();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImCharIsBlankW();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImClamp();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImDot();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImFileClose();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong ImFileGetSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr ImFileLoadToMemory();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr ImFileOpen();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong ImFileRead();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ulong ImFileWrite();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImFloor_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFloor_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImFloorSigned_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFloorSigned_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlasBuildFinish();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlasBuildInit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlasBuildMultiplyCalcLookupTable();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlasBuildMultiplyRectAlpha8();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlasBuildPackCustomRects();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlasBuildRender32bppRectFromString();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlasBuildRender8bppRectFromString();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImFontAtlasBuildSetupFont();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr* ImFontAtlasGetBuilderForStbTruetype();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImFormatString();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImFormatStringV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiDir ImGetDirQuadrantFromDelta();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImHashData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint ImHashStr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImInvLength();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImIsFloatAboveGuaranteedIntegerPrecision();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImIsPowerOfTwo_Int();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImIsPowerOfTwo_U64();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImLengthSqr_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImLengthSqr_Vec4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImLerp_Vec2Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImLerp_Vec2Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImLerp_Vec4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImLineClosestPoint();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImLinearSweep();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImLog_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern double ImLog_double();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImMax();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImMin();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImModPositive();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImMul();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImParseFormatFindEnd();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImParseFormatFindStart();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImParseFormatPrecision();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImParseFormatTrimDecorations();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImPow_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern double ImPow_double();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImRotate();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImRsqrt_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern double ImRsqrt_double();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImSaturate();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImSign_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern double ImSign_double();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImStrSkipBlank();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImStrTrimBlanks();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ushort* ImStrbolW();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImStrchrRange();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern string ImStrdup();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern string ImStrdupcpy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImStreolRange();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImStricmp();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImStristr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImStrlenW();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImStrncpy();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImStrnicmp();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImTextCharFromUtf8();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* ImTextCharToUtf8();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImTextCountCharsFromUtf8();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImTextCountUtf8BytesFromChar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImTextCountUtf8BytesFromStr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImTextStrFromUtf8();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImTextStrToUtf8();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float ImTriangleArea();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImTriangleBarycentricCoords();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImTriangleClosestPoint();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImTriangleContainsPoint();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int ImUpperPowerOfTwo();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Image();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImageButton();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImageButtonEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Indent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Initialize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputDouble();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputFloat();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputFloat2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputFloat3();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputFloat4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputInt();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputInt2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputInt3();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputInt4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputScalar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputScalarN();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputTextEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputTextMultiline();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InputTextWithHint();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool InvisibleButton();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsActiveIdUsingKey();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsActiveIdUsingNavDir();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsActiveIdUsingNavInput();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsAnyItemActive();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsAnyItemFocused();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsAnyItemHovered();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsAnyMouseDown();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsClippedEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsDragDropPayloadBeingAccepted();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsGamepadKey();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemActivated();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemActive();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemClicked();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemDeactivated();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemDeactivatedAfterEdit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemEdited();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemFocused();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemHovered();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemToggledOpen();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemToggledSelection();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsItemVisible();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsKeyDown();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsKeyPressed();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsKeyPressedMap();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsKeyReleased();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsLegacyKey();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsMouseClicked();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsMouseDoubleClicked();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsMouseDown();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsMouseDragPastThreshold();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsMouseDragging();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsMouseHoveringRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsMousePosValid();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsMouseReleased();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsNamedKey();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsNavInputDown();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsNavInputTest();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsPopupOpen_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsPopupOpen_ID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsRectVisible_Nil();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsRectVisible_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsWindowAbove();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsWindowAppearing();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsWindowChildOf();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsWindowCollapsed();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsWindowFocused();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsWindowHovered();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsWindowNavFocusable();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool IsWindowWithinBeginStackOf();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ItemAdd();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ItemHoverable();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ItemSize_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ItemSize_Rect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void KeepAliveID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LabelText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LabelTextV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ListBox_Str_arr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LoadIniSettingsFromDisk();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LoadIniSettingsFromMemory();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogBegin();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogButtons();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogFinish();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogRenderedText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogSetNextTextDecoration();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogTextV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogToBuffer();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogToClipboard();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogToFile();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void LogToTTY();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void MarkIniSettingsDirty_Nil();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void MarkIniSettingsDirty_WindowPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void MarkItemEdited();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr MemAlloc();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void MemFree();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MenuItem_Bool();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MenuItem_BoolPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool MenuItemEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NavInitRequestApplyResult();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NavInitWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NavMoveRequestApplyResult();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool NavMoveRequestButNoResultYet();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NavMoveRequestCancel();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NavMoveRequestForward();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NavMoveRequestResolveWithLastItem();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NavMoveRequestSubmit();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NavMoveRequestTryWrapping();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NewFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NewLine();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void NextColumn();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void OpenPopup_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void OpenPopup_ID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void OpenPopupEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void OpenPopupOnItemClick();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PlotHistogram_FloatPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PlotLines_FloatPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopAllowKeyboardFocus();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopButtonRepeat();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopClipRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopColumnsBackground();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopFocusScope();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopFont();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopItemFlag();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopItemWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopStyleColor();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopStyleVar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PopTextWrapPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ProgressBar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushAllowKeyboardFocus();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushButtonRepeat();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushClipRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushColumnClipRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushColumnsBackground();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushFocusScope();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushFont();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushID_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushID_StrStr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushID_Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushID_Int();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushItemFlag();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushItemWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushMultiItemsWidths();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushOverrideID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushStyleColor_U32();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushStyleColor_Vec4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushStyleVar_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushStyleVar_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void PushTextWrapPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool RadioButton_Bool();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool RadioButton_IntPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RemoveContextHook();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Render();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderArrow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderArrowPointingAt();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderBullet();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderCheckMark();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderColorRectWithAlphaCheckerboard();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderFrameBorder();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderMouseCursor();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderNavHighlight();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderRectFilledRangeH();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderRectFilledWithHole();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderTextClipped();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderTextClippedEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderTextEllipsis();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void RenderTextWrapped();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ResetMouseDragDelta();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SameLine();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SaveIniSettingsToDisk();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* SaveIniSettingsToMemory();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ScrollToBringRectIntoView();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ScrollToItem();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ScrollToRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ScrollToRectEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Scrollbar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ScrollbarEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool Selectable_Bool();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool Selectable_BoolPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Separator();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SeparatorEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetActiveID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetActiveIdUsingKey();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetActiveIdUsingNavAndKeys();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetAllocatorFunctions();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetClipboardText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetColorEditOptions();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetColumnOffset();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetColumnWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetCurrentContext();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetCurrentFont();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetCursorPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetCursorPosX();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetCursorPosY();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetCursorScreenPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SetDragDropPayload();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetFocusID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetHoveredID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetItemAllowOverlap();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetItemDefaultFocus();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetItemUsingMouseWheel();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetKeyboardFocusHere();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetLastItemData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetMouseCursor();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNavID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextItemOpen();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextItemWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextWindowBgAlpha();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextWindowCollapsed();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextWindowContentSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextWindowFocus();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextWindowPos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextWindowScroll();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextWindowSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetNextWindowSizeConstraints();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollFromPosX_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollFromPosX_WindowPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollFromPosY_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollFromPosY_WindowPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollHereX();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollHereY();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollX_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollX_WindowPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollY_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetScrollY_WindowPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetStateStorage();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetTabItemClosed();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetTooltip();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetTooltipV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowClipRectBeforeSetChannel();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowCollapsed_Bool();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowCollapsed_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowCollapsed_WindowPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowFocus_Nil();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowFocus_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowFontScale();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowHitTestHole();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowPos_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowPos_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowPos_WindowPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowSize_Vec2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowSize_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void SetWindowSize_WindowPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShadeVertsLinearColorGradientKeepAlpha();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShadeVertsLinearUV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShowAboutWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShowDemoWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShowFontAtlas();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShowFontSelector();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShowMetricsWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShowStackToolWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShowStyleEditor();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ShowStyleSelector();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShowUserGuide();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ShrinkWidths();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Shutdown();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderAngle();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderBehavior();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderFloat();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderFloat2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderFloat3();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderFloat4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderInt();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderInt2();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderInt3();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderInt4();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderScalar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SliderScalarN();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SmallButton();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Spacing();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool SplitterBehavior();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void StartMouseMovingWindow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void StyleColorsClassic();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void StyleColorsDark();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void StyleColorsLight();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TabBarCloseTab();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiTabItem* TabBarFindTabByID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TabBarProcessReorder();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TabBarQueueReorder();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TabBarQueueReorderFromMousePos();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TabBarRemoveTab();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TabItemBackground();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TabItemButton();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TabItemCalcSize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TabItemEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TabItemLabelAndCloseButton();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableBeginApplyRequests();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableBeginCell();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableBeginInitMemory();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableBeginRow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableDrawBorders();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableDrawContextMenu();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableEndCell();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableEndRow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiTable* TableFindByID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableFixColumnSortDirection();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableGcCompactSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableGcCompactTransientBuffers_TablePtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableGcCompactTransientBuffers_TableTempDataPtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiTableSettings* TableGetBoundSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableGetCellBgRect();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int TableGetColumnCount();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiTableColumnFlags TableGetColumnFlags();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int TableGetColumnIndex();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* TableGetColumnName_Int();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern byte* TableGetColumnName_TablePtr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiSortDirection TableGetColumnNextSortDirection();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern uint TableGetColumnResizeID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float TableGetColumnWidthAuto();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float TableGetHeaderRowHeight();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int TableGetHoveredColumn();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern float TableGetMaxColumnWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern int TableGetRowIndex();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiTableSortSpecs* TableGetSortSpecs();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableHeader();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableHeadersRow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableLoadSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableMergeDrawChannels();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TableNextColumn();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableNextRow();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableOpenContextMenu();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TablePopBackgroundChannel();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TablePushBackgroundChannel();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableRemove();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableResetSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSaveSettings();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSetBgColor();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSetColumnEnabled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TableSetColumnIndex();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSetColumnSortDirection();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSetColumnWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSetColumnWidthAutoAll();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSetColumnWidthAutoSingle();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiTableSettings* TableSettingsCreate();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern ImGuiTableSettings* TableSettingsFindByID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSettingsInstallHandler();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSetupColumn();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSetupDrawChannels();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSetupScrollFreeze();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSortSpecsBuild();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableSortSpecsSanitize();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableUpdateBorders();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableUpdateColumnsWeightFromWidth();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TableUpdateLayout();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TempInputIsActive();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TempInputScalar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TempInputText();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Text();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TextColored();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TextColoredV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TextDisabled();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TextDisabledV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TextEx();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TextUnformatted();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TextV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TextWrapped();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TextWrappedV();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNode_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNode_StrStr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNode_Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNodeBehavior();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNodeBehaviorIsOpen();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNodeEx_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNodeEx_StrStr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNodeEx_Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNodeExV_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNodeExV_Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNodeV_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool TreeNodeV_Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TreePop();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TreePush_Str();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TreePush_Ptr();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void TreePushOverrideID();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Unindent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void UpdateHoveredWindowAndCaptureFlags();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void UpdateInputEvents();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void UpdateMouseMovingWindowEndFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void UpdateMouseMovingWindowNewFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void UpdateWindowParentAndRootLinks();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool VSliderFloat();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool VSliderInt();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool VSliderScalar();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Value_Bool();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Value_Int();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Value_Uint();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void Value_Float();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void WindowRectAbsToRel();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void WindowRectRelToAbs();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_CharCallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_CursorEnterCallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_CursorPosCallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplGlfw_InitForOpenGL();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplGlfw_InitForOther();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplGlfw_InitForVulkan();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_InstallCallbacks();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_KeyCallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_MonitorCallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_MouseButtonCallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_NewFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_RestoreCallbacks();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_ScrollCallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_Shutdown();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplGlfw_WindowFocusCallback();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplOpenGL2_CreateDeviceObjects();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplOpenGL2_CreateFontsTexture();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL2_DestroyDeviceObjects();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL2_DestroyFontsTexture();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplOpenGL2_Init();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL2_NewFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL2_RenderDrawData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL2_Shutdown();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplOpenGL3_CreateDeviceObjects();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplOpenGL3_CreateFontsTexture();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL3_DestroyDeviceObjects();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL3_DestroyFontsTexture();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplOpenGL3_Init();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL3_NewFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL3_RenderDrawData();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplOpenGL3_Shutdown();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplSDL2_InitForD3D();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplSDL2_InitForMetal();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplSDL2_InitForOpenGL();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplSDL2_InitForSDLRenderer();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplSDL2_InitForVulkan();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplSDL2_NewFrame();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern bool ImGui_ImplSDL2_ProcessEvent();
    [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
    public static extern void ImGui_ImplSDL2_Shutdown();
}
