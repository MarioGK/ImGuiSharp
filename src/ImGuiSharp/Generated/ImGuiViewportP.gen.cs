// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiViewportP
{
    public ImGuiViewport ImGuiViewport;
    public int DrawListsLastFrame[2];
    public ImDrawList* DrawLists[2];
    public ImDrawData DrawDataP;
    public ImDrawDataBuilder DrawDataBuilder;
    public Vector2 WorkOffsetMin;
    public Vector2 WorkOffsetMax;
    public Vector2 BuildWorkOffsetMin;
    public Vector2 BuildWorkOffsetMax;

}
