// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiStackLevelInfo
{
        public uint ID;
        public sbyte QueryFrameCount;
        public byte QuerySuccess;
        public fixed byte Desc[58];
}
