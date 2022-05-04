using System.Collections.Generic;
using CodeGenerator.Fixes;

namespace CodeGenerator;

//TODO do this on the generation step not post fix, but for now this works
public static class PostFixes
{
    public static List<PostFix> CreateImGuiFixes()
    {
        var imGuiStyleMod = new PostFix("ImGuiStyleMod.gen.cs");
        imGuiStyleMod.RemoveLines("union");

        var imGuiViewportP = new PostFix("ImGuiViewportP.gen.cs");
        imGuiViewportP.Replace("RangeAccessor<ImDrawList*", "RangeAccessor<ImDrawList");

        var imGuiContext = new PostFix("ImGuiContext.gen.cs");
        imGuiContext.RemoveLines("ImChunkStream", "ImGuiItemFlagsPtr", "NativePtr->Tables", "NativePtr->TabBars");

        var imGui = new PostFix("ImGui.gen.cs");
        imGui.RemoveLinesAfter("Vector2 FindBestWindowPosForPopupEx", 8);
        imGui.Replace("IntPtr callback = null", "IntPtr callback = IntPtr.Zero");
        imGui.Replace("ImGuiPopupFlags_None", "ImGuiPopupFlags.None");
        imGui.Replace("ImGuiNavHighlightFlags_TypeDefault", "ImGuiNavHighlightFlags.TypeDefault");
        imGui.Replace("IntPtr custom_callback = null", "IntPtr custom_callback = IntPtr.Zero");
        imGui.Replace("ImGuiContext* ctx = IntPtr.Zero;", "ImGuiContext* ctx = null;");

        var imGuiInputEvent = new PostFix("ImGuiInputEvent.gen.cs");
        imGuiInputEvent.RemoveLines("union");

        return new List<PostFix>
        {
            imGuiStyleMod,
            imGuiViewportP,
            imGuiContext,
            imGui,
            imGuiInputEvent
        };
    }

    public static void FixShit(string rootPath)
    {
        var imguiFixes = CreateImGuiFixes();
        foreach (var fix in imguiFixes) fix.ApplyAll(rootPath);
    }
}