// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiPayload
{
    public void* Data;
    public int DataSize;
    public uint SourceId;
    public uint SourceParentId;
    public int DataFrameCount;
    public byte DataType[32+1];
    public byte Preview;
    public byte Delivery;

}
