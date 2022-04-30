// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiViewport
{
    public ImGuiViewportFlags Flags;
    public Vector2 Pos;
    public Vector2 Size;
    public Vector2 WorkPos;
    public Vector2 WorkSize;
    public void* PlatformHandleRaw;

}
