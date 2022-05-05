// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiWindowStackData
{
        public ImGuiWindow* Window;
        public ImGuiLastItemData ParentLastItemDataBackup;
        public ImGuiStackSizes StackSizesOnBegin;
}
