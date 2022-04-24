using System.Text;

// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public static unsafe partial class ImGui
{
    public static bool Begin(string name, ImGuiWindowFlags flags)
    {
        var   utf8NameByteCount = Encoding.UTF8.GetByteCount(name);
        byte* utf8NameBytes;
        if (utf8NameByteCount > Util.StackAllocationSizeLimit)
        {
            utf8NameBytes = Util.Allocate(utf8NameByteCount + 1);
        }
        else
        {
            var stackPtr = stackalloc byte[utf8NameByteCount + 1];
            utf8NameBytes = stackPtr;
        }
        Util.GetUtf8(name, utf8NameBytes, utf8NameByteCount);

        byte* pOpen = null;
        var   ret   = ImGuiNative.igBegin(utf8NameBytes, pOpen, flags);

        if (utf8NameByteCount > Util.StackAllocationSizeLimit)
        {
            Util.Free(utf8NameBytes);
        }

        return ret != 0;
    }

    public static bool MenuItem(string label, bool enabled)
    {
        return MenuItem(label, string.Empty, false, enabled);
    }
}