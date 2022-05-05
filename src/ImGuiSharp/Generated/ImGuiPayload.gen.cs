// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiPayload
{
        public void* Data;
        public int DataSize;
        public uint SourceId;
        public uint SourceParentId;
        public int DataFrameCount;
        public fixed byte DataType[33];
        public byte Preview;
        public byte Delivery;
}
