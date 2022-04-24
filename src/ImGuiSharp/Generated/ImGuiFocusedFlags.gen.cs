// ReSharper disable once CheckNamespace
namespace ImGuiSharp
{
    [System.Flags]
    public enum ImGuiFocusedFlags
    {
        None = 0,
        ChildWindows = 1,
        RootWindow = 2,
        AnyWindow = 4,
        NoPopupHierarchy = 8,
        RootAndChildWindows = 3,
    }
}
