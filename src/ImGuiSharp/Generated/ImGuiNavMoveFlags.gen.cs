// ReSharper disable once CheckNamespace
namespace ImGuiSharp
{
    [System.Flags]
    public enum ImGuiNavMoveFlags
    {
        None = 0,
        LoopX = 1,
        LoopY = 2,
        WrapX = 4,
        WrapY = 8,
        AllowCurrentNavId = 16,
        AlsoScoreVisibleSet = 32,
        ScrollToEdgeY = 64,
        Forwarded = 128,
        DebugNoResult = 256,
        FocusApi = 512,
        Tabbing = 1024,
        Activate = 2048,
        DontSetNavHighlight = 4096,
    }
}
