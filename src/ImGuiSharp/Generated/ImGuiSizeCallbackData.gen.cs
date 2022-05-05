// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiSizeCallbackData
{
        public void* UserData;
        public Vector2 Pos;
        public Vector2 CurrentSize;
        public Vector2 DesiredSize;
}
