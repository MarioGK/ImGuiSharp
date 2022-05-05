// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiStackLevelInfo
{
        public uint ID;
        public sbyte QueryFrameCount;
        public byte QuerySuccess;
        public fixed byte Desc[58];
}
public unsafe partial struct ImGuiStackLevelInfoPtr
{
    public ImGuiStackLevelInfo* NativePtr { get; }
    public ImGuiStackLevelInfoPtr(ImGuiStackLevelInfo* nativePtr) => NativePtr = nativePtr;
    public ImGuiStackLevelInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiStackLevelInfo*)nativePtr;
    public static implicit operator ImGuiStackLevelInfoPtr(ImGuiStackLevelInfo* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiStackLevelInfo* (ImGuiStackLevelInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiStackLevelInfoPtr(IntPtr nativePtr) => new (nativePtr);
    public RangeAccessor<byte> Desc => new (NativePtr->Desc, 58);
}
