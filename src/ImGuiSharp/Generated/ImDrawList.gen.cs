// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawList
{
        public ImVector CmdBuffer;
        public ImVector IdxBuffer;
        public ImVector VtxBuffer;
        public ImDrawListFlags Flags;
        public uint _VtxCurrentIdx;
        public IntPtr _Data;
        public byte* _OwnerName;
        public ImDrawVert* _VtxWritePtr;
        public ushort* _IdxWritePtr;
        public ImVector _ClipRectStack;
        public ImVector _TextureIdStack;
        public ImVector _Path;
        public ImDrawCmdHeader _CmdHeader;
        public ImDrawListSplitter _Splitter;
        public float _FringeScale;
}
