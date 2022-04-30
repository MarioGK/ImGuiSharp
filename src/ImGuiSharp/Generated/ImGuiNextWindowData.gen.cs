// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

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
