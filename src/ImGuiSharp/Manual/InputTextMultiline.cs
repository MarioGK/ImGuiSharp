using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public static unsafe partial class ImGui
{
   public static bool InputTextMultiline(
        string     label,
        ref string input,
        uint       maxLength,
        Vector2    size) => InputTextMultiline(label, ref input, maxLength, size, 0, null, IntPtr.Zero);

    public static bool InputTextMultiline(
        string              label,
        ref string          input,
        uint                maxLength,
        Vector2             size,
        ImGuiInputTextFlags flags) => InputTextMultiline(label, ref input, maxLength, size, flags, null, IntPtr.Zero);

    public static bool InputTextMultiline(
        string label,
        ref string input,
        uint maxLength,
        Vector2 size,
        ImGuiInputTextFlags flags,
        ImGuiInputTextCallback callback) => InputTextMultiline(label, ref input, maxLength, size, flags, callback, IntPtr.Zero);

    public static bool InputTextMultiline(
        string                 label,
        ref string             input,
        uint                   maxLength,
        Vector2                size,
        ImGuiInputTextFlags    flags,
        ImGuiInputTextCallback callback,
        IntPtr                 userData)
    {
        var   utf8LabelByteCount = Encoding.UTF8.GetByteCount(label);
        byte* utf8LabelBytes;
        if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
        {
            utf8LabelBytes = Util.Allocate(utf8LabelByteCount + 1);
        }
        else
        {
            var stackPtr = stackalloc byte[utf8LabelByteCount + 1];
            utf8LabelBytes = stackPtr;
        }
        Util.GetUtf8(label, utf8LabelBytes, utf8LabelByteCount);

        var utf8InputByteCount = Encoding.UTF8.GetByteCount(input);
        var inputBufSize       = Math.Max((int)maxLength + 1, utf8InputByteCount + 1);

        byte* utf8InputBytes;
        byte* originalUtf8InputBytes;
        if (inputBufSize > Util.StackAllocationSizeLimit)
        {
            utf8InputBytes         = Util.Allocate(inputBufSize);
            originalUtf8InputBytes = Util.Allocate(inputBufSize);
        }
        else
        {
            var inputStackBytes = stackalloc byte[inputBufSize];
            utf8InputBytes = inputStackBytes;
            var originalInputStackBytes = stackalloc byte[inputBufSize];
            originalUtf8InputBytes = originalInputStackBytes;
        }
        Util.GetUtf8(input, utf8InputBytes, inputBufSize);
        var clearBytesCount = (uint)(inputBufSize - utf8InputByteCount);
        Unsafe.InitBlockUnaligned(utf8InputBytes + utf8InputByteCount, 0, clearBytesCount);
        Unsafe.CopyBlock(originalUtf8InputBytes, utf8InputBytes, (uint)inputBufSize);

        var result = ImGuiNative.igInputTextMultiline(
                                                      utf8LabelBytes,
                                                      utf8InputBytes,
                                                      (uint)inputBufSize,
                                                      size,
                                                      flags,
                                                      callback,
                                                      userData.ToPointer());
        if (!Util.AreStringsEqual(originalUtf8InputBytes, inputBufSize, utf8InputBytes))
        {
            input = Util.StringFromPtr(utf8InputBytes);
        }

        if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
        {
            Util.Free(utf8LabelBytes);
        }
        if (inputBufSize > Util.StackAllocationSizeLimit)
        {
            Util.Free(utf8InputBytes);
            Util.Free(originalUtf8InputBytes);
        }

        return result != 0;
    }
}