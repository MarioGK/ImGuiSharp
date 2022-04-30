// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiWindowStackData
{
    public ImGuiWindow* Window;
    public ImGuiLastItemData ParentLastItemDataBackup;
    public ImGuiStackSizes StackSizesOnBegin;

}
