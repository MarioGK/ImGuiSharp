using System.Text;

namespace ImGuiSharp
{
    public unsafe struct NullTerminatedString
    {
        public readonly byte* Data;

        public NullTerminatedString(byte* data)
        {
            Data = data;
        }

        public override string ToString()
        {
            var length = 0;
            var ptr = Data;
            while (*ptr != 0)
            {
                length += 1;
                ptr += 1;
            }

            return Encoding.ASCII.GetString(Data, length);
        }

        public static implicit operator string(NullTerminatedString nts) => nts.ToString();
    }
}
