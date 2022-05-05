// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiViewportP
{
        public ImGuiViewport _ImGuiViewport;
        public fixed int DrawListsLastFrame[2];
        public ImDrawList* DrawLists_0;
        public ImDrawList* DrawLists_1;
        public ImDrawList* DrawLists_2;
        public ImDrawData DrawDataP;
        public ImDrawDataBuilder DrawDataBuilder;
        public Vector2 WorkOffsetMin;
        public Vector2 WorkOffsetMax;
        public Vector2 BuildWorkOffsetMin;
        public Vector2 BuildWorkOffsetMax;
}
