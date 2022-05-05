// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTabItem
{
        public uint ID;
        public ImGuiTabItemFlags Flags;
        public int LastFrameVisible;
        public int LastFrameSelected;
        public float Offset;
        public float Width;
        public float ContentWidth;
        public int NameOffset;
        public short BeginOrder;
        public short IndexDuringLayout;
        public byte WantClose;
}
