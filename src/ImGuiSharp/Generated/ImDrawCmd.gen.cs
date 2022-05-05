// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawCmd
{
        public Vector4 ClipRect;
        public IntPtr TextureId;
        public uint VtxOffset;
        public uint IdxOffset;
        public uint ElemCount;
        public IntPtr UserCallback;
        public void* UserCallbackData;
}
