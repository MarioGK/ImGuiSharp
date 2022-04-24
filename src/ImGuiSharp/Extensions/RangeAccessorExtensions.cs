using System.Text;

namespace ImGuiSharp.Structs;

public static class RangeAccessorExtensions
{
    public static unsafe string GetStringASCII(this RangeAccessor<byte> stringAccessor)
    {
        return Encoding.ASCII.GetString((byte*)stringAccessor.Data, stringAccessor.Count);
    }
}