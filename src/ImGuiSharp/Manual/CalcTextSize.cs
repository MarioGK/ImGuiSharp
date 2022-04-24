using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public static unsafe partial class ImGui
{
   public static Vector2 CalcTextSize(string text)
        => CalcTextSizeImpl(text);

    public static Vector2 CalcTextSize(string text, int start)
        => CalcTextSizeImpl(text, start);

    public static Vector2 CalcTextSize(string text, float wrapWidth)
        => CalcTextSizeImpl(text, wrapWidth: wrapWidth);

    public static Vector2 CalcTextSize(string text, bool hideTextAfterDoubleHash)
        => CalcTextSizeImpl(text, hideTextAfterDoubleHash: hideTextAfterDoubleHash);

    public static Vector2 CalcTextSize(string text, int start, int length)
        => CalcTextSizeImpl(text, start, length);

    public static Vector2 CalcTextSize(string text, int start, bool hideTextAfterDoubleHash)
        => CalcTextSizeImpl(text, start, hideTextAfterDoubleHash: hideTextAfterDoubleHash);

    public static Vector2 CalcTextSize(string text, int start, float wrapWidth)
        => CalcTextSizeImpl(text, start, wrapWidth: wrapWidth);

    public static Vector2 CalcTextSize(string text, bool hideTextAfterDoubleHash, float wrapWidth)
        => CalcTextSizeImpl(text, hideTextAfterDoubleHash: hideTextAfterDoubleHash, wrapWidth: wrapWidth);

    public static Vector2 CalcTextSize(string text, int start, int length, bool hideTextAfterDoubleHash)
        => CalcTextSizeImpl(text, start, length, hideTextAfterDoubleHash);

    public static Vector2 CalcTextSize(string text, int start, int length, float wrapWidth)
        => CalcTextSizeImpl(text, start, length, wrapWidth: wrapWidth);

    public static Vector2 CalcTextSize(string text, int start, int length, bool hideTextAfterDoubleHash, float wrapWidth)
        => CalcTextSizeImpl(text, start, length, hideTextAfterDoubleHash, wrapWidth);

    private static Vector2 CalcTextSizeImpl(
        string text,
        int    start                   = 0,
        int?   length                  = null,
        bool   hideTextAfterDoubleHash = false,
        float  wrapWidth               = -1.0f)
    {
        Vector2 ret;
        byte*   nativeTextStart = null;
        byte*   nativeTextEnd   = null;
        var     textByteCount   = 0;
        if (text != null)
        {

            var textToCopyLen = length.HasValue ? length.Value : text.Length;
            textByteCount = Util.CalcSizeInUtf8(text, start, textToCopyLen);
            if (textByteCount > Util.StackAllocationSizeLimit)
            {
                nativeTextStart = Util.Allocate(textByteCount + 1);
            }
            else
            {
                var nativeTextStackBytes = stackalloc byte[textByteCount + 1];
                nativeTextStart = nativeTextStackBytes;
            }

            var nativeTextOffset = Util.GetUtf8(text, start, textToCopyLen, nativeTextStart, textByteCount);
            nativeTextStart[nativeTextOffset] = 0;
            nativeTextEnd                     = nativeTextStart + nativeTextOffset;
        }

        ImGuiNative.igCalcTextSize(&ret, nativeTextStart, nativeTextEnd, *((byte*)(&hideTextAfterDoubleHash)), wrapWidth);
        if (textByteCount > Util.StackAllocationSizeLimit)
        {
            Util.Free(nativeTextStart);
        }

        return ret;
    }
}