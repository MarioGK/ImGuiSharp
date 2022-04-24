using System.Numerics;
using System.Text;

namespace ImGuiSharp;

public unsafe partial struct ImDrawListPtr
{
    public void AddText(Vector2 pos, uint col, string textBegin)
    {
        var textBeginByteCount = Encoding.UTF8.GetByteCount(textBegin);
        var nativeTextBegin    = stackalloc byte[textBeginByteCount + 1];
        fixed (char* textBeginPtr = textBegin)
        {
            var nativeTextBeginOffset = Encoding.UTF8.GetBytes(textBeginPtr, textBegin.Length, nativeTextBegin, textBeginByteCount);
            nativeTextBegin[nativeTextBeginOffset] = 0;
        }
        byte* nativeTextEnd = null;
        ImGuiNative.ImDrawList_AddText_Vec2(NativePtr, pos, col, nativeTextBegin, nativeTextEnd);
    }

    public void AddText(ImFontPtr font, float fontSize, Vector2 pos, uint col, string textBegin)
    {
        var nativeFont         = font.NativePtr;
        var textBeginByteCount = Encoding.UTF8.GetByteCount(textBegin);
        var nativeTextBegin    = stackalloc byte[textBeginByteCount + 1];
        fixed (char* textBeginPtr = textBegin)
        {
            var nativeTextBeginOffset = Encoding.UTF8.GetBytes(textBeginPtr, textBegin.Length, nativeTextBegin, textBeginByteCount);
            nativeTextBegin[nativeTextBeginOffset] = 0;
        }
        byte* nativeTextEnd = null;
        var wrapWidth = 0.0f;
        Vector4* cpuFineClipRect = null;
        ImGuiNative.ImDrawList_AddText_FontPtr(NativePtr, nativeFont, fontSize, pos, col, nativeTextBegin, nativeTextEnd, wrapWidth, cpuFineClipRect);
    }
}