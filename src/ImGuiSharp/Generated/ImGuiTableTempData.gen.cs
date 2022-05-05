// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTableTempData
{
        public int TableIndex;
        public float LastTimeActive;
        public Vector2 UserOuterSize;
        public ImDrawListSplitter DrawSplitter;
        public ImRect HostBackupWorkRect;
        public ImRect HostBackupParentWorkRect;
        public Vector2 HostBackupPrevLineSize;
        public Vector2 HostBackupCurrLineSize;
        public Vector2 HostBackupCursorMaxPos;
        public ImVec1 HostBackupColumnsOffset;
        public float HostBackupItemWidth;
        public int HostBackupItemWidthStackSize;
}
