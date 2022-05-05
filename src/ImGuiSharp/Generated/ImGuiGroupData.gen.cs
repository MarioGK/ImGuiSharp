// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiGroupData
{
        public uint WindowID;
        public Vector2 BackupCursorPos;
        public Vector2 BackupCursorMaxPos;
        public ImVec1 BackupIndent;
        public ImVec1 BackupGroupOffset;
        public Vector2 BackupCurrLineSize;
        public float BackupCurrLineTextBaseOffset;
        public uint BackupActiveIdIsAlive;
        public byte BackupActiveIdPreviousFrameIsAlive;
        public byte BackupHoveredIdIsAlive;
        public byte EmitItem;
}
