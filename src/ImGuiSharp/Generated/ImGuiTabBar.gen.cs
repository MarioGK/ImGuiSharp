// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiTabBar
{
    public ImVector Tabs;
    public ImGuiTabBarFlags Flags;
    public uint ID;
    public uint SelectedTabId;
    public uint NextSelectedTabId;
    public uint VisibleTabId;
    public int CurrFrameVisible;
    public int PrevFrameVisible;
    public ImRect BarRect;
    public float CurrTabsContentsHeight;
    public float PrevTabsContentsHeight;
    public float WidthAllTabs;
    public float WidthAllTabsIdeal;
    public float ScrollingAnim;
    public float ScrollingTarget;
    public float ScrollingTargetDistToVisibility;
    public float ScrollingSpeed;
    public float ScrollingRectMinX;
    public float ScrollingRectMaxX;
    public uint ReorderRequestTabId;
    public short ReorderRequestOffset;
    public sbyte BeginCount;
    public byte WantLayout;
    public byte VisibleTabWasSubmitted;
    public byte TabsAddedNew;
    public short TabsActiveCount;
    public short LastTabItemIdx;
    public float ItemSpacingY;
    public Vector2 FramePadding;
    public Vector2 BackupCursorPos;
    public ImGuiTextBuffer TabsNames;

}
