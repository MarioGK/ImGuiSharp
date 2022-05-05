// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiViewportP
{
        public ImGuiViewport ImGuiViewport;
        public fixed int DrawListsLastFrame[2];
        public ImDrawList* DrawLists0;
        public ImDrawList* DrawLists1;
        public ImDrawList* DrawLists2;
        public ImDrawData DrawDataP;
        public ImDrawDataBuilder DrawDataBuilder;
        public Vector2 WorkOffsetMin;
        public Vector2 WorkOffsetMax;
        public Vector2 BuildWorkOffsetMin;
        public Vector2 BuildWorkOffsetMax;
}
