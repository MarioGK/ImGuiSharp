// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTextFilter
{
        public fixed byte InputBuf[256];
        public ImVector Filters;
        public int CountGrep;
}
