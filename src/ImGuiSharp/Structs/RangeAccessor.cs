using System;
using System.Runtime.CompilerServices;

namespace ImGuiSharp.Structs;

public unsafe readonly struct RangeAccessor<T> where T : struct
{
    private static readonly int SSizeOfT = Unsafe.SizeOf<T>();

    public readonly void* Data;
    public readonly int   Count;

    public RangeAccessor(IntPtr data, int count) : this(data.ToPointer(), count)
    {
    }

    public RangeAccessor(void* data, int count)
    {
        Data  = data;
        Count = count;
    }

    public ref T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            return ref Unsafe.AsRef<T>((byte*) Data + SSizeOfT * index);
        }
    }
}