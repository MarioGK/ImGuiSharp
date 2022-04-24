using System;
using System.Runtime.CompilerServices;
using System.Text;

// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public static unsafe partial class ImGui
{
    public static bool InputText(
        string label,
        byte[] buf,
        uint   bufSize)
    {
        return InputText(label, buf, bufSize, 0, null, IntPtr.Zero);
    }

    public static bool InputText(
        string              label,
        byte[]              buf,
        uint                bufSize,
        ImGuiInputTextFlags flags)
    {
        return InputText(label, buf, bufSize, flags, null, IntPtr.Zero);
    }

    public static bool InputText(
        string                 label,
        byte[]                 buf,
        uint                   bufSize,
        ImGuiInputTextFlags    flags,
        ImGuiInputTextCallback callback)
    {
        return InputText(label, buf, bufSize, flags, callback, IntPtr.Zero);
    }

    public static bool InputText(
        string                 label,
        byte[]                 buf,
        uint                   bufSize,
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

        bool ret;
        fixed (byte* bufPtr = buf)
        {
            ret = ImGuiNative.igInputText(utf8LabelBytes, bufPtr, bufSize, flags, callback, userData.ToPointer()) != 0;
        }

        if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
        {
            Util.Free(utf8LabelBytes);
        }

        return ret;
    }

    public static bool InputText(
        string     label,
        ref string input,
        uint       maxLength) => InputText(label, ref input, maxLength, 0, null, IntPtr.Zero);

    public static bool InputText(
        string              label,
        ref string          input,
        uint                maxLength,
        ImGuiInputTextFlags flags) => InputText(label, ref input, maxLength, flags, null, IntPtr.Zero);

    public static bool InputText(
        string                 label,
        ref string             input,
        uint                   maxLength,
        ImGuiInputTextFlags    flags,
        ImGuiInputTextCallback callback) => InputText(label, ref input, maxLength, flags, callback, IntPtr.Zero);

    public static bool InputText(
        string                 label,
        ref string             input,
        uint                   maxLength,
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
        var inputBufSize       = Math.Max((int) maxLength + 1, utf8InputByteCount + 1);

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
        var clearBytesCount = (uint) (inputBufSize - utf8InputByteCount);
        Unsafe.InitBlockUnaligned(utf8InputBytes + utf8InputByteCount, 0, clearBytesCount);
        Unsafe.CopyBlock(originalUtf8InputBytes, utf8InputBytes, (uint) inputBufSize);

        var result = ImGuiNative.igInputText(
                                             utf8LabelBytes,
                                             utf8InputBytes,
                                             (uint) inputBufSize,
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

    public static bool InputText(
        string label,
        IntPtr buf,
        uint   bufSize)
    {
        return InputText(label, buf, bufSize, 0, null, IntPtr.Zero);
    }

    public static bool InputText(
        string              label,
        IntPtr              buf,
        uint                bufSize,
        ImGuiInputTextFlags flags)
    {
        return InputText(label, buf, bufSize, flags, null, IntPtr.Zero);
    }

    public static bool InputText(
        string                 label,
        IntPtr                 buf,
        uint                   bufSize,
        ImGuiInputTextFlags    flags,
        ImGuiInputTextCallback callback)
    {
        return InputText(label, buf, bufSize, flags, callback, IntPtr.Zero);
    }

    public static bool InputText(
        string                 label,
        IntPtr                 buf,
        uint                   bufSize,
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

        var ret = ImGuiNative.igInputText(utf8LabelBytes, (byte*) buf.ToPointer(), bufSize, flags, callback,
                                          userData.ToPointer()) != 0;

        if (utf8LabelByteCount > Util.StackAllocationSizeLimit)
        {
            Util.Free(utf8LabelBytes);
        }

        return ret;
    }
}