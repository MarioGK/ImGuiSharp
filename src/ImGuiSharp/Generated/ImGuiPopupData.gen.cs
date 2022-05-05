// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiPopupData
{
        public uint PopupId;
        public ImGuiWindow* Window;
        public ImGuiWindow* SourceWindow;
        public int OpenFrameCount;
        public uint OpenParentId;
        public Vector2 OpenPopupPos;
        public Vector2 OpenMousePos;
}
