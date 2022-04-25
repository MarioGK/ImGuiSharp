using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiSharp.Structs;

// ReSharper disable once CheckNamespace
namespace ImGuiSharp
{
    public unsafe partial struct ImGuiContext
    {
        public byte Initialized;
        public byte FontAtlasOwnedByContext;
        public ImGuiIO IO;
        public ImVector InputEventsQueue;
        public ImVector InputEventsTrail;
        public ImGuiStyle Style;
        public ImFont* Font;
        public float FontSize;
        public float FontBaseSize;
        public IntPtr DrawListSharedData;
        public double Time;
        public int FrameCount;
        public int FrameCountEnded;
        public int FrameCountRendered;
        public byte WithinFrameScope;
        public byte WithinFrameScopeWithImplicitWindow;
        public byte WithinEndChild;
        public byte GcCompactAll;
        public byte TestEngineHookItems;
        public void* TestEngine;
        public ImVector Windows;
        public ImVector WindowsFocusOrder;
        public ImVector WindowsTempSortBuffer;
        public ImVector CurrentWindowStack;
        public ImGuiStorage WindowsById;
        public int WindowsActiveCount;
        public Vector2 WindowsHoverPadding;
        public ImGuiWindow* CurrentWindow;
        public ImGuiWindow* HoveredWindow;
        public ImGuiWindow* HoveredWindowUnderMovingWindow;
        public ImGuiWindow* MovingWindow;
        public ImGuiWindow* WheelingWindow;
        public Vector2 WheelingWindowRefMousePos;
        public float WheelingWindowTimer;
        public uint DebugHookIdInfo;
        public uint HoveredId;
        public uint HoveredIdPreviousFrame;
        public byte HoveredIdAllowOverlap;
        public byte HoveredIdUsingMouseWheel;
        public byte HoveredIdPreviousFrameUsingMouseWheel;
        public byte HoveredIdDisabled;
        public float HoveredIdTimer;
        public float HoveredIdNotActiveTimer;
        public uint ActiveId;
        public uint ActiveIdIsAlive;
        public float ActiveIdTimer;
        public byte ActiveIdIsJustActivated;
        public byte ActiveIdAllowOverlap;
        public byte ActiveIdNoClearOnFocusLoss;
        public byte ActiveIdHasBeenPressedBefore;
        public byte ActiveIdHasBeenEditedBefore;
        public byte ActiveIdHasBeenEditedThisFrame;
        public byte ActiveIdUsingMouseWheel;
        public uint ActiveIdUsingNavDirMask;
        public uint ActiveIdUsingNavInputMask;
        public IntPtr ActiveIdUsingKeyInputMask;
        public Vector2 ActiveIdClickOffset;
        public ImGuiWindow* ActiveIdWindow;
        public ImGuiInputSource ActiveIdSource;
        public int ActiveIdMouseButton;
        public uint ActiveIdPreviousFrame;
        public byte ActiveIdPreviousFrameIsAlive;
        public byte ActiveIdPreviousFrameHasBeenEditedBefore;
        public ImGuiWindow* ActiveIdPreviousFrameWindow;
        public uint LastActiveId;
        public float LastActiveIdTimer;
        public ImGuiItemFlags CurrentItemFlags;
        public ImGuiNextItemData NextItemData;
        public ImGuiLastItemData LastItemData;
        public ImGuiNextWindowData NextWindowData;
        public ImVector ColorStack;
        public ImVector StyleVarStack;
        public ImVector FontStack;
        public ImVector FocusScopeStack;
        public ImVector ItemFlagsStack;
        public ImVector GroupStack;
        public ImVector OpenPopupStack;
        public ImVector BeginPopupStack;
        public int BeginMenuCount;
        public ImVector Viewports;
        public ImGuiWindow* NavWindow;
        public uint NavId;
        public uint NavFocusScopeId;
        public uint NavActivateId;
        public uint NavActivateDownId;
        public uint NavActivatePressedId;
        public uint NavActivateInputId;
        public ImGuiActivateFlags NavActivateFlags;
        public uint NavJustMovedToId;
        public uint NavJustMovedToFocusScopeId;
        public ImGuiKeyModFlags NavJustMovedToKeyMods;
        public uint NavNextActivateId;
        public ImGuiActivateFlags NavNextActivateFlags;
        public ImGuiInputSource NavInputSource;
        public ImGuiNavLayer NavLayer;
        public byte NavIdIsAlive;
        public byte NavMousePosDirty;
        public byte NavDisableHighlight;
        public byte NavDisableMouseHover;
        public byte NavAnyRequest;
        public byte NavInitRequest;
        public byte NavInitRequestFromMove;
        public uint NavInitResultId;
        public ImRect NavInitResultRectRel;
        public byte NavMoveSubmitted;
        public byte NavMoveScoringItems;
        public byte NavMoveForwardToNextFrame;
        public ImGuiNavMoveFlags NavMoveFlags;
        public ImGuiScrollFlags NavMoveScrollFlags;
        public ImGuiKeyModFlags NavMoveKeyMods;
        public ImGuiDir NavMoveDir;
        public ImGuiDir NavMoveDirForDebug;
        public ImGuiDir NavMoveClipDir;
        public ImRect NavScoringRect;
        public ImRect NavScoringNoClipRect;
        public int NavScoringDebugCount;
        public int NavTabbingDir;
        public int NavTabbingCounter;
        public ImGuiNavItemData NavMoveResultLocal;
        public ImGuiNavItemData NavMoveResultLocalVisible;
        public ImGuiNavItemData NavMoveResultOther;
        public ImGuiNavItemData NavTabbingResultFirst;
        public ImGuiWindow* NavWindowingTarget;
        public ImGuiWindow* NavWindowingTargetAnim;
        public ImGuiWindow* NavWindowingListWindow;
        public float NavWindowingTimer;
        public float NavWindowingHighlightAlpha;
        public byte NavWindowingToggleLayer;
        public float DimBgRatio;
        public ImGuiMouseCursor MouseCursor;
        public byte DragDropActive;
        public byte DragDropWithinSource;
        public byte DragDropWithinTarget;
        public ImGuiDragDropFlags DragDropSourceFlags;
        public int DragDropSourceFrameCount;
        public int DragDropMouseButton;
        public ImGuiPayload DragDropPayload;
        public ImRect DragDropTargetRect;
        public uint DragDropTargetId;
        public ImGuiDragDropFlags DragDropAcceptFlags;
        public float DragDropAcceptIdCurrRectSurface;
        public uint DragDropAcceptIdCurr;
        public uint DragDropAcceptIdPrev;
        public int DragDropAcceptFrameCount;
        public uint DragDropHoldJustPressedId;
        public ImVector DragDropPayloadBufHeap;
        public fixed byte DragDropPayloadBufLocal[16];
        public int ClipperTempDataStacked;
        public ImVector ClipperTempData;
        public ImGuiTable* CurrentTable;
        public int TablesTempDataStacked;
        public ImVector TablesTempData;
        public IntPtr Tables;
        public ImVector TablesLastTimeActive;
        public ImVector DrawChannelsTempMergeBuffer;
        public ImGuiTabBar* CurrentTabBar;
        public IntPtr TabBars;
        public ImVector CurrentTabBarStack;
        public ImVector ShrinkWidthBuffer;
        public Vector2 MouseLastValidPos;
        public ImGuiInputTextState InputTextState;
        public ImFont InputTextPasswordFont;
        public uint TempInputId;
        public ImGuiColorEditFlags ColorEditOptions;
        public float ColorEditLastHue;
        public float ColorEditLastSat;
        public uint ColorEditLastColor;
        public Vector4 ColorPickerRef;
        public ImGuiComboPreviewData ComboPreviewData;
        public float SliderCurrentAccum;
        public byte SliderCurrentAccumDirty;
        public byte DragCurrentAccumDirty;
        public float DragCurrentAccum;
        public float DragSpeedDefaultRatio;
        public float ScrollbarClickDeltaToGrabCenter;
        public float DisabledAlphaBackup;
        public short DisabledStackSize;
        public short TooltipOverrideCount;
        public float TooltipSlowDelay;
        public ImVector ClipboardHandlerData;
        public ImVector MenusIdSubmittedThisFrame;
        public ImGuiPlatformImeData PlatformImeData;
        public ImGuiPlatformImeData PlatformImeDataPrev;
        public byte PlatformLocaleDecimalPoint;
        public byte SettingsLoaded;
        public float SettingsDirtyTimer;
        public ImGuiTextBuffer SettingsIniData;
        public ImVector SettingsHandlers;
        public ImVector Hooks;
        public uint HookIdNext;
        public byte LogEnabled;
        public ImGuiLogType LogType;
        public IntPtr LogFile;
        public ImGuiTextBuffer LogBuffer;
        public byte* LogNextPrefix;
        public byte* LogNextSuffix;
        public float LogLinePosY;
        public byte LogLineFirstItem;
        public int LogDepthRef;
        public int LogDepthToExpand;
        public int LogDepthToExpandDefault;
        public byte DebugItemPickerActive;
        public uint DebugItemPickerBreakId;
        public ImGuiMetricsConfig DebugMetricsConfig;
        public ImGuiStackTool DebugStackTool;
        public fixed float FramerateSecPerFrame[120];
        public int FramerateSecPerFrameIdx;
        public int FramerateSecPerFrameCount;
        public float FramerateSecPerFrameAccum;
        public int WantCaptureMouseNextFrame;
        public int WantCaptureKeyboardNextFrame;
        public int WantTextInputNextFrame;
        public fixed byte TempBuffer[3073];
    }
    public unsafe partial struct ImGuiContextPtr
    {
        public ImGuiContext* NativePtr { get; }
        public ImGuiContextPtr(ImGuiContext* nativePtr) => NativePtr = nativePtr;
        public ImGuiContextPtr(IntPtr nativePtr) => NativePtr = (ImGuiContext*)nativePtr;
        public static implicit operator ImGuiContextPtr(ImGuiContext* nativePtr) => new ImGuiContextPtr(nativePtr);
        public static implicit operator ImGuiContext* (ImGuiContextPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiContextPtr(IntPtr nativePtr) => new ImGuiContextPtr(nativePtr);
        public ref bool Initialized => ref Unsafe.AsRef<bool>(&NativePtr->Initialized);
        public ref bool FontAtlasOwnedByContext => ref Unsafe.AsRef<bool>(&NativePtr->FontAtlasOwnedByContext);
        public ref ImGuiIO IO => ref Unsafe.AsRef<ImGuiIO>(&NativePtr->IO);
        public ImPtrVector<ImGuiInputEventPtr> InputEventsQueue => new ImPtrVector<ImGuiInputEventPtr>(NativePtr->InputEventsQueue, Unsafe.SizeOf<ImGuiInputEvent>());
        public ImPtrVector<ImGuiInputEventPtr> InputEventsTrail => new ImPtrVector<ImGuiInputEventPtr>(NativePtr->InputEventsTrail, Unsafe.SizeOf<ImGuiInputEvent>());
        public ref ImGuiStyle Style => ref Unsafe.AsRef<ImGuiStyle>(&NativePtr->Style);
        public ImFontPtr Font => new ImFontPtr(NativePtr->Font);
        public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);
        public ref float FontBaseSize => ref Unsafe.AsRef<float>(&NativePtr->FontBaseSize);
        public ref IntPtr DrawListSharedData => ref Unsafe.AsRef<IntPtr>(&NativePtr->DrawListSharedData);
        public ref double Time => ref Unsafe.AsRef<double>(&NativePtr->Time);
        public ref int FrameCount => ref Unsafe.AsRef<int>(&NativePtr->FrameCount);
        public ref int FrameCountEnded => ref Unsafe.AsRef<int>(&NativePtr->FrameCountEnded);
        public ref int FrameCountRendered => ref Unsafe.AsRef<int>(&NativePtr->FrameCountRendered);
        public ref bool WithinFrameScope => ref Unsafe.AsRef<bool>(&NativePtr->WithinFrameScope);
        public ref bool WithinFrameScopeWithImplicitWindow => ref Unsafe.AsRef<bool>(&NativePtr->WithinFrameScopeWithImplicitWindow);
        public ref bool WithinEndChild => ref Unsafe.AsRef<bool>(&NativePtr->WithinEndChild);
        public ref bool GcCompactAll => ref Unsafe.AsRef<bool>(&NativePtr->GcCompactAll);
        public ref bool TestEngineHookItems => ref Unsafe.AsRef<bool>(&NativePtr->TestEngineHookItems);
        public IntPtr TestEngine { get => (IntPtr)NativePtr->TestEngine; set => NativePtr->TestEngine = (void*)value; }
        public ImVector<ImGuiWindowPtr> Windows => new ImVector<ImGuiWindowPtr>(NativePtr->Windows);
        public ImVector<ImGuiWindowPtr> WindowsFocusOrder => new ImVector<ImGuiWindowPtr>(NativePtr->WindowsFocusOrder);
        public ImVector<ImGuiWindowPtr> WindowsTempSortBuffer => new ImVector<ImGuiWindowPtr>(NativePtr->WindowsTempSortBuffer);
        public ImPtrVector<ImGuiWindowStackDataPtr> CurrentWindowStack => new ImPtrVector<ImGuiWindowStackDataPtr>(NativePtr->CurrentWindowStack, Unsafe.SizeOf<ImGuiWindowStackData>());
        public ref ImGuiStorage WindowsById => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->WindowsById);
        public ref int WindowsActiveCount => ref Unsafe.AsRef<int>(&NativePtr->WindowsActiveCount);
        public ref Vector2 WindowsHoverPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->WindowsHoverPadding);
        public ImGuiWindowPtr CurrentWindow => new ImGuiWindowPtr(NativePtr->CurrentWindow);
        public ImGuiWindowPtr HoveredWindow => new ImGuiWindowPtr(NativePtr->HoveredWindow);
        public ImGuiWindowPtr HoveredWindowUnderMovingWindow => new ImGuiWindowPtr(NativePtr->HoveredWindowUnderMovingWindow);
        public ImGuiWindowPtr MovingWindow => new ImGuiWindowPtr(NativePtr->MovingWindow);
        public ImGuiWindowPtr WheelingWindow => new ImGuiWindowPtr(NativePtr->WheelingWindow);
        public ref Vector2 WheelingWindowRefMousePos => ref Unsafe.AsRef<Vector2>(&NativePtr->WheelingWindowRefMousePos);
        public ref float WheelingWindowTimer => ref Unsafe.AsRef<float>(&NativePtr->WheelingWindowTimer);
        public ref uint DebugHookIdInfo => ref Unsafe.AsRef<uint>(&NativePtr->DebugHookIdInfo);
        public ref uint HoveredId => ref Unsafe.AsRef<uint>(&NativePtr->HoveredId);
        public ref uint HoveredIdPreviousFrame => ref Unsafe.AsRef<uint>(&NativePtr->HoveredIdPreviousFrame);
        public ref bool HoveredIdAllowOverlap => ref Unsafe.AsRef<bool>(&NativePtr->HoveredIdAllowOverlap);
        public ref bool HoveredIdUsingMouseWheel => ref Unsafe.AsRef<bool>(&NativePtr->HoveredIdUsingMouseWheel);
        public ref bool HoveredIdPreviousFrameUsingMouseWheel => ref Unsafe.AsRef<bool>(&NativePtr->HoveredIdPreviousFrameUsingMouseWheel);
        public ref bool HoveredIdDisabled => ref Unsafe.AsRef<bool>(&NativePtr->HoveredIdDisabled);
        public ref float HoveredIdTimer => ref Unsafe.AsRef<float>(&NativePtr->HoveredIdTimer);
        public ref float HoveredIdNotActiveTimer => ref Unsafe.AsRef<float>(&NativePtr->HoveredIdNotActiveTimer);
        public ref uint ActiveId => ref Unsafe.AsRef<uint>(&NativePtr->ActiveId);
        public ref uint ActiveIdIsAlive => ref Unsafe.AsRef<uint>(&NativePtr->ActiveIdIsAlive);
        public ref float ActiveIdTimer => ref Unsafe.AsRef<float>(&NativePtr->ActiveIdTimer);
        public ref bool ActiveIdIsJustActivated => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdIsJustActivated);
        public ref bool ActiveIdAllowOverlap => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdAllowOverlap);
        public ref bool ActiveIdNoClearOnFocusLoss => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdNoClearOnFocusLoss);
        public ref bool ActiveIdHasBeenPressedBefore => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdHasBeenPressedBefore);
        public ref bool ActiveIdHasBeenEditedBefore => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdHasBeenEditedBefore);
        public ref bool ActiveIdHasBeenEditedThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdHasBeenEditedThisFrame);
        public ref bool ActiveIdUsingMouseWheel => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdUsingMouseWheel);
        public ref uint ActiveIdUsingNavDirMask => ref Unsafe.AsRef<uint>(&NativePtr->ActiveIdUsingNavDirMask);
        public ref uint ActiveIdUsingNavInputMask => ref Unsafe.AsRef<uint>(&NativePtr->ActiveIdUsingNavInputMask);
        public ref IntPtr ActiveIdUsingKeyInputMask => ref Unsafe.AsRef<IntPtr>(&NativePtr->ActiveIdUsingKeyInputMask);
        public ref Vector2 ActiveIdClickOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->ActiveIdClickOffset);
        public ImGuiWindowPtr ActiveIdWindow => new ImGuiWindowPtr(NativePtr->ActiveIdWindow);
        public ref ImGuiInputSource ActiveIdSource => ref Unsafe.AsRef<ImGuiInputSource>(&NativePtr->ActiveIdSource);
        public ref int ActiveIdMouseButton => ref Unsafe.AsRef<int>(&NativePtr->ActiveIdMouseButton);
        public ref uint ActiveIdPreviousFrame => ref Unsafe.AsRef<uint>(&NativePtr->ActiveIdPreviousFrame);
        public ref bool ActiveIdPreviousFrameIsAlive => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdPreviousFrameIsAlive);
        public ref bool ActiveIdPreviousFrameHasBeenEditedBefore => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdPreviousFrameHasBeenEditedBefore);
        public ImGuiWindowPtr ActiveIdPreviousFrameWindow => new ImGuiWindowPtr(NativePtr->ActiveIdPreviousFrameWindow);
        public ref uint LastActiveId => ref Unsafe.AsRef<uint>(&NativePtr->LastActiveId);
        public ref float LastActiveIdTimer => ref Unsafe.AsRef<float>(&NativePtr->LastActiveIdTimer);
        public ref ImGuiItemFlags CurrentItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->CurrentItemFlags);
        public ref ImGuiNextItemData NextItemData => ref Unsafe.AsRef<ImGuiNextItemData>(&NativePtr->NextItemData);
        public ref ImGuiLastItemData LastItemData => ref Unsafe.AsRef<ImGuiLastItemData>(&NativePtr->LastItemData);
        public ref ImGuiNextWindowData NextWindowData => ref Unsafe.AsRef<ImGuiNextWindowData>(&NativePtr->NextWindowData);
        public ImPtrVector<ImGuiColorModPtr> ColorStack => new ImPtrVector<ImGuiColorModPtr>(NativePtr->ColorStack, Unsafe.SizeOf<ImGuiColorMod>());
        public ImPtrVector<ImGuiStyleModPtr> StyleVarStack => new ImPtrVector<ImGuiStyleModPtr>(NativePtr->StyleVarStack, Unsafe.SizeOf<ImGuiStyleMod>());
        public ImVector<ImFontPtr> FontStack => new ImVector<ImFontPtr>(NativePtr->FontStack);
        public ImVector<uint> FocusScopeStack => new ImVector<uint>(NativePtr->FocusScopeStack);
        public ImPtrVector<ImGuiGroupDataPtr> GroupStack => new ImPtrVector<ImGuiGroupDataPtr>(NativePtr->GroupStack, Unsafe.SizeOf<ImGuiGroupData>());
        public ImPtrVector<ImGuiPopupDataPtr> OpenPopupStack => new ImPtrVector<ImGuiPopupDataPtr>(NativePtr->OpenPopupStack, Unsafe.SizeOf<ImGuiPopupData>());
        public ImPtrVector<ImGuiPopupDataPtr> BeginPopupStack => new ImPtrVector<ImGuiPopupDataPtr>(NativePtr->BeginPopupStack, Unsafe.SizeOf<ImGuiPopupData>());
        public ref int BeginMenuCount => ref Unsafe.AsRef<int>(&NativePtr->BeginMenuCount);
        public ImVector<ImGuiViewportPPtr> Viewports => new ImVector<ImGuiViewportPPtr>(NativePtr->Viewports);
        public ImGuiWindowPtr NavWindow => new ImGuiWindowPtr(NativePtr->NavWindow);
        public ref uint NavId => ref Unsafe.AsRef<uint>(&NativePtr->NavId);
        public ref uint NavFocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->NavFocusScopeId);
        public ref uint NavActivateId => ref Unsafe.AsRef<uint>(&NativePtr->NavActivateId);
        public ref uint NavActivateDownId => ref Unsafe.AsRef<uint>(&NativePtr->NavActivateDownId);
        public ref uint NavActivatePressedId => ref Unsafe.AsRef<uint>(&NativePtr->NavActivatePressedId);
        public ref uint NavActivateInputId => ref Unsafe.AsRef<uint>(&NativePtr->NavActivateInputId);
        public ref ImGuiActivateFlags NavActivateFlags => ref Unsafe.AsRef<ImGuiActivateFlags>(&NativePtr->NavActivateFlags);
        public ref uint NavJustMovedToId => ref Unsafe.AsRef<uint>(&NativePtr->NavJustMovedToId);
        public ref uint NavJustMovedToFocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->NavJustMovedToFocusScopeId);
        public ref ImGuiKeyModFlags NavJustMovedToKeyMods => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->NavJustMovedToKeyMods);
        public ref uint NavNextActivateId => ref Unsafe.AsRef<uint>(&NativePtr->NavNextActivateId);
        public ref ImGuiActivateFlags NavNextActivateFlags => ref Unsafe.AsRef<ImGuiActivateFlags>(&NativePtr->NavNextActivateFlags);
        public ref ImGuiInputSource NavInputSource => ref Unsafe.AsRef<ImGuiInputSource>(&NativePtr->NavInputSource);
        public ref ImGuiNavLayer NavLayer => ref Unsafe.AsRef<ImGuiNavLayer>(&NativePtr->NavLayer);
        public ref bool NavIdIsAlive => ref Unsafe.AsRef<bool>(&NativePtr->NavIdIsAlive);
        public ref bool NavMousePosDirty => ref Unsafe.AsRef<bool>(&NativePtr->NavMousePosDirty);
        public ref bool NavDisableHighlight => ref Unsafe.AsRef<bool>(&NativePtr->NavDisableHighlight);
        public ref bool NavDisableMouseHover => ref Unsafe.AsRef<bool>(&NativePtr->NavDisableMouseHover);
        public ref bool NavAnyRequest => ref Unsafe.AsRef<bool>(&NativePtr->NavAnyRequest);
        public ref bool NavInitRequest => ref Unsafe.AsRef<bool>(&NativePtr->NavInitRequest);
        public ref bool NavInitRequestFromMove => ref Unsafe.AsRef<bool>(&NativePtr->NavInitRequestFromMove);
        public ref uint NavInitResultId => ref Unsafe.AsRef<uint>(&NativePtr->NavInitResultId);
        public ref ImRect NavInitResultRectRel => ref Unsafe.AsRef<ImRect>(&NativePtr->NavInitResultRectRel);
        public ref bool NavMoveSubmitted => ref Unsafe.AsRef<bool>(&NativePtr->NavMoveSubmitted);
        public ref bool NavMoveScoringItems => ref Unsafe.AsRef<bool>(&NativePtr->NavMoveScoringItems);
        public ref bool NavMoveForwardToNextFrame => ref Unsafe.AsRef<bool>(&NativePtr->NavMoveForwardToNextFrame);
        public ref ImGuiNavMoveFlags NavMoveFlags => ref Unsafe.AsRef<ImGuiNavMoveFlags>(&NativePtr->NavMoveFlags);
        public ref ImGuiScrollFlags NavMoveScrollFlags => ref Unsafe.AsRef<ImGuiScrollFlags>(&NativePtr->NavMoveScrollFlags);
        public ref ImGuiKeyModFlags NavMoveKeyMods => ref Unsafe.AsRef<ImGuiKeyModFlags>(&NativePtr->NavMoveKeyMods);
        public ref ImGuiDir NavMoveDir => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->NavMoveDir);
        public ref ImGuiDir NavMoveDirForDebug => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->NavMoveDirForDebug);
        public ref ImGuiDir NavMoveClipDir => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->NavMoveClipDir);
        public ref ImRect NavScoringRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavScoringRect);
        public ref ImRect NavScoringNoClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavScoringNoClipRect);
        public ref int NavScoringDebugCount => ref Unsafe.AsRef<int>(&NativePtr->NavScoringDebugCount);
        public ref int NavTabbingDir => ref Unsafe.AsRef<int>(&NativePtr->NavTabbingDir);
        public ref int NavTabbingCounter => ref Unsafe.AsRef<int>(&NativePtr->NavTabbingCounter);
        public ref ImGuiNavItemData NavMoveResultLocal => ref Unsafe.AsRef<ImGuiNavItemData>(&NativePtr->NavMoveResultLocal);
        public ref ImGuiNavItemData NavMoveResultLocalVisible => ref Unsafe.AsRef<ImGuiNavItemData>(&NativePtr->NavMoveResultLocalVisible);
        public ref ImGuiNavItemData NavMoveResultOther => ref Unsafe.AsRef<ImGuiNavItemData>(&NativePtr->NavMoveResultOther);
        public ref ImGuiNavItemData NavTabbingResultFirst => ref Unsafe.AsRef<ImGuiNavItemData>(&NativePtr->NavTabbingResultFirst);
        public ImGuiWindowPtr NavWindowingTarget => new ImGuiWindowPtr(NativePtr->NavWindowingTarget);
        public ImGuiWindowPtr NavWindowingTargetAnim => new ImGuiWindowPtr(NativePtr->NavWindowingTargetAnim);
        public ImGuiWindowPtr NavWindowingListWindow => new ImGuiWindowPtr(NativePtr->NavWindowingListWindow);
        public ref float NavWindowingTimer => ref Unsafe.AsRef<float>(&NativePtr->NavWindowingTimer);
        public ref float NavWindowingHighlightAlpha => ref Unsafe.AsRef<float>(&NativePtr->NavWindowingHighlightAlpha);
        public ref bool NavWindowingToggleLayer => ref Unsafe.AsRef<bool>(&NativePtr->NavWindowingToggleLayer);
        public ref float DimBgRatio => ref Unsafe.AsRef<float>(&NativePtr->DimBgRatio);
        public ref ImGuiMouseCursor MouseCursor => ref Unsafe.AsRef<ImGuiMouseCursor>(&NativePtr->MouseCursor);
        public ref bool DragDropActive => ref Unsafe.AsRef<bool>(&NativePtr->DragDropActive);
        public ref bool DragDropWithinSource => ref Unsafe.AsRef<bool>(&NativePtr->DragDropWithinSource);
        public ref bool DragDropWithinTarget => ref Unsafe.AsRef<bool>(&NativePtr->DragDropWithinTarget);
        public ref ImGuiDragDropFlags DragDropSourceFlags => ref Unsafe.AsRef<ImGuiDragDropFlags>(&NativePtr->DragDropSourceFlags);
        public ref int DragDropSourceFrameCount => ref Unsafe.AsRef<int>(&NativePtr->DragDropSourceFrameCount);
        public ref int DragDropMouseButton => ref Unsafe.AsRef<int>(&NativePtr->DragDropMouseButton);
        public ref ImGuiPayload DragDropPayload => ref Unsafe.AsRef<ImGuiPayload>(&NativePtr->DragDropPayload);
        public ref ImRect DragDropTargetRect => ref Unsafe.AsRef<ImRect>(&NativePtr->DragDropTargetRect);
        public ref uint DragDropTargetId => ref Unsafe.AsRef<uint>(&NativePtr->DragDropTargetId);
        public ref ImGuiDragDropFlags DragDropAcceptFlags => ref Unsafe.AsRef<ImGuiDragDropFlags>(&NativePtr->DragDropAcceptFlags);
        public ref float DragDropAcceptIdCurrRectSurface => ref Unsafe.AsRef<float>(&NativePtr->DragDropAcceptIdCurrRectSurface);
        public ref uint DragDropAcceptIdCurr => ref Unsafe.AsRef<uint>(&NativePtr->DragDropAcceptIdCurr);
        public ref uint DragDropAcceptIdPrev => ref Unsafe.AsRef<uint>(&NativePtr->DragDropAcceptIdPrev);
        public ref int DragDropAcceptFrameCount => ref Unsafe.AsRef<int>(&NativePtr->DragDropAcceptFrameCount);
        public ref uint DragDropHoldJustPressedId => ref Unsafe.AsRef<uint>(&NativePtr->DragDropHoldJustPressedId);
        public ImVector<byte> DragDropPayloadBufHeap => new ImVector<byte>(NativePtr->DragDropPayloadBufHeap);
        public RangeAccessor<byte> DragDropPayloadBufLocal => new RangeAccessor<byte>(NativePtr->DragDropPayloadBufLocal, 16);
        public ref int ClipperTempDataStacked => ref Unsafe.AsRef<int>(&NativePtr->ClipperTempDataStacked);
        public ImPtrVector<ImGuiListClipperDataPtr> ClipperTempData => new ImPtrVector<ImGuiListClipperDataPtr>(NativePtr->ClipperTempData, Unsafe.SizeOf<ImGuiListClipperData>());
        public ImGuiTablePtr CurrentTable => new ImGuiTablePtr(NativePtr->CurrentTable);
        public ImPtrVector<ImDrawChannelPtr> DrawChannelsTempMergeBuffer => new ImPtrVector<ImDrawChannelPtr>(NativePtr->DrawChannelsTempMergeBuffer, Unsafe.SizeOf<ImDrawChannel>());
        public ImGuiTabBarPtr CurrentTabBar => new ImGuiTabBarPtr(NativePtr->CurrentTabBar);
        public ImPtrVector<ImGuiPtrOrIndexPtr> CurrentTabBarStack => new ImPtrVector<ImGuiPtrOrIndexPtr>(NativePtr->CurrentTabBarStack, Unsafe.SizeOf<ImGuiPtrOrIndex>());
        public ImPtrVector<ImGuiShrinkWidthItemPtr> ShrinkWidthBuffer => new ImPtrVector<ImGuiShrinkWidthItemPtr>(NativePtr->ShrinkWidthBuffer, Unsafe.SizeOf<ImGuiShrinkWidthItem>());
        public ref Vector2 MouseLastValidPos => ref Unsafe.AsRef<Vector2>(&NativePtr->MouseLastValidPos);
        public ref ImGuiInputTextState InputTextState => ref Unsafe.AsRef<ImGuiInputTextState>(&NativePtr->InputTextState);
        public ref ImFont InputTextPasswordFont => ref Unsafe.AsRef<ImFont>(&NativePtr->InputTextPasswordFont);
        public ref uint TempInputId => ref Unsafe.AsRef<uint>(&NativePtr->TempInputId);
        public ref ImGuiColorEditFlags ColorEditOptions => ref Unsafe.AsRef<ImGuiColorEditFlags>(&NativePtr->ColorEditOptions);
        public ref float ColorEditLastHue => ref Unsafe.AsRef<float>(&NativePtr->ColorEditLastHue);
        public ref float ColorEditLastSat => ref Unsafe.AsRef<float>(&NativePtr->ColorEditLastSat);
        public ref uint ColorEditLastColor => ref Unsafe.AsRef<uint>(&NativePtr->ColorEditLastColor);
        public ref Vector4 ColorPickerRef => ref Unsafe.AsRef<Vector4>(&NativePtr->ColorPickerRef);
        public ref ImGuiComboPreviewData ComboPreviewData => ref Unsafe.AsRef<ImGuiComboPreviewData>(&NativePtr->ComboPreviewData);
        public ref float SliderCurrentAccum => ref Unsafe.AsRef<float>(&NativePtr->SliderCurrentAccum);
        public ref bool SliderCurrentAccumDirty => ref Unsafe.AsRef<bool>(&NativePtr->SliderCurrentAccumDirty);
        public ref bool DragCurrentAccumDirty => ref Unsafe.AsRef<bool>(&NativePtr->DragCurrentAccumDirty);
        public ref float DragCurrentAccum => ref Unsafe.AsRef<float>(&NativePtr->DragCurrentAccum);
        public ref float DragSpeedDefaultRatio => ref Unsafe.AsRef<float>(&NativePtr->DragSpeedDefaultRatio);
        public ref float ScrollbarClickDeltaToGrabCenter => ref Unsafe.AsRef<float>(&NativePtr->ScrollbarClickDeltaToGrabCenter);
        public ref float DisabledAlphaBackup => ref Unsafe.AsRef<float>(&NativePtr->DisabledAlphaBackup);
        public ref short DisabledStackSize => ref Unsafe.AsRef<short>(&NativePtr->DisabledStackSize);
        public ref short TooltipOverrideCount => ref Unsafe.AsRef<short>(&NativePtr->TooltipOverrideCount);
        public ref float TooltipSlowDelay => ref Unsafe.AsRef<float>(&NativePtr->TooltipSlowDelay);
        public ImVector<byte> ClipboardHandlerData => new ImVector<byte>(NativePtr->ClipboardHandlerData);
        public ImVector<uint> MenusIdSubmittedThisFrame => new ImVector<uint>(NativePtr->MenusIdSubmittedThisFrame);
        public ref ImGuiPlatformImeData PlatformImeData => ref Unsafe.AsRef<ImGuiPlatformImeData>(&NativePtr->PlatformImeData);
        public ref ImGuiPlatformImeData PlatformImeDataPrev => ref Unsafe.AsRef<ImGuiPlatformImeData>(&NativePtr->PlatformImeDataPrev);
        public ref byte PlatformLocaleDecimalPoint => ref Unsafe.AsRef<byte>(&NativePtr->PlatformLocaleDecimalPoint);
        public ref bool SettingsLoaded => ref Unsafe.AsRef<bool>(&NativePtr->SettingsLoaded);
        public ref float SettingsDirtyTimer => ref Unsafe.AsRef<float>(&NativePtr->SettingsDirtyTimer);
        public ref ImGuiTextBuffer SettingsIniData => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->SettingsIniData);
        public ImPtrVector<ImGuiSettingsHandlerPtr> SettingsHandlers => new ImPtrVector<ImGuiSettingsHandlerPtr>(NativePtr->SettingsHandlers, Unsafe.SizeOf<ImGuiSettingsHandler>());
        public ImPtrVector<ImGuiContextHookPtr> Hooks => new ImPtrVector<ImGuiContextHookPtr>(NativePtr->Hooks, Unsafe.SizeOf<ImGuiContextHook>());
        public ref uint HookIdNext => ref Unsafe.AsRef<uint>(&NativePtr->HookIdNext);
        public ref bool LogEnabled => ref Unsafe.AsRef<bool>(&NativePtr->LogEnabled);
        public ref ImGuiLogType LogType => ref Unsafe.AsRef<ImGuiLogType>(&NativePtr->LogType);
        public ref IntPtr LogFile => ref Unsafe.AsRef<IntPtr>(&NativePtr->LogFile);
        public ref ImGuiTextBuffer LogBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->LogBuffer);
        public IntPtr LogNextPrefix { get => (IntPtr)NativePtr->LogNextPrefix; set => NativePtr->LogNextPrefix = (byte*)value; }
        public IntPtr LogNextSuffix { get => (IntPtr)NativePtr->LogNextSuffix; set => NativePtr->LogNextSuffix = (byte*)value; }
        public ref float LogLinePosY => ref Unsafe.AsRef<float>(&NativePtr->LogLinePosY);
        public ref bool LogLineFirstItem => ref Unsafe.AsRef<bool>(&NativePtr->LogLineFirstItem);
        public ref int LogDepthRef => ref Unsafe.AsRef<int>(&NativePtr->LogDepthRef);
        public ref int LogDepthToExpand => ref Unsafe.AsRef<int>(&NativePtr->LogDepthToExpand);
        public ref int LogDepthToExpandDefault => ref Unsafe.AsRef<int>(&NativePtr->LogDepthToExpandDefault);
        public ref bool DebugItemPickerActive => ref Unsafe.AsRef<bool>(&NativePtr->DebugItemPickerActive);
        public ref uint DebugItemPickerBreakId => ref Unsafe.AsRef<uint>(&NativePtr->DebugItemPickerBreakId);
        public ref ImGuiMetricsConfig DebugMetricsConfig => ref Unsafe.AsRef<ImGuiMetricsConfig>(&NativePtr->DebugMetricsConfig);
        public ref ImGuiStackTool DebugStackTool => ref Unsafe.AsRef<ImGuiStackTool>(&NativePtr->DebugStackTool);
        public RangeAccessor<float> FramerateSecPerFrame => new RangeAccessor<float>(NativePtr->FramerateSecPerFrame, 120);
        public ref int FramerateSecPerFrameIdx => ref Unsafe.AsRef<int>(&NativePtr->FramerateSecPerFrameIdx);
        public ref int FramerateSecPerFrameCount => ref Unsafe.AsRef<int>(&NativePtr->FramerateSecPerFrameCount);
        public ref float FramerateSecPerFrameAccum => ref Unsafe.AsRef<float>(&NativePtr->FramerateSecPerFrameAccum);
        public ref int WantCaptureMouseNextFrame => ref Unsafe.AsRef<int>(&NativePtr->WantCaptureMouseNextFrame);
        public ref int WantCaptureKeyboardNextFrame => ref Unsafe.AsRef<int>(&NativePtr->WantCaptureKeyboardNextFrame);
        public ref int WantTextInputNextFrame => ref Unsafe.AsRef<int>(&NativePtr->WantTextInputNextFrame);
        public RangeAccessor<byte> TempBuffer => new RangeAccessor<byte>(NativePtr->TempBuffer, 3073);
        public void Destroy()
        {
            ImGuiNative.ImGuiContext_destroy((IntPtr)(NativePtr));
        }
    }
}
