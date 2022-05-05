// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiNavItemData
{
        public ImGuiWindow* Window;
        public uint ID;
        public uint FocusScopeId;
        public ImRect RectRel;
        public ImGuiItemFlags InFlags;
        public float DistBox;
        public float DistCenter;
        public float DistAxial;
}
