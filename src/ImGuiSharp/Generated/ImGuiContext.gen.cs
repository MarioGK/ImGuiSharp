// ReSharper disable once CheckNamespace
namespace ImGui;
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
        public byte DragDropPayloadBufLocal_0;
        public byte DragDropPayloadBufLocal_1;
        public byte DragDropPayloadBufLocal_2;
        public byte DragDropPayloadBufLocal_3;
        public byte DragDropPayloadBufLocal_4;
        public byte DragDropPayloadBufLocal_5;
        public byte DragDropPayloadBufLocal_6;
        public byte DragDropPayloadBufLocal_7;
        public byte DragDropPayloadBufLocal_8;
        public byte DragDropPayloadBufLocal_9;
        public byte DragDropPayloadBufLocal_10;
        public byte DragDropPayloadBufLocal_11;
        public byte DragDropPayloadBufLocal_12;
        public byte DragDropPayloadBufLocal_13;
        public byte DragDropPayloadBufLocal_14;
        public byte DragDropPayloadBufLocal_15;
        public byte DragDropPayloadBufLocal_16;
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
        public ImChunkStream SettingsWindows;
        public ImChunkStream SettingsTables;
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