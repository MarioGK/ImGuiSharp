using System;
using System.Runtime.CompilerServices;

namespace ImGuiSharp.Structs;

public unsafe readonly struct RangePtrAccessor<T> where T : struct
{
    public readonly void* Data;
    public readonly int   Count;

    public RangePtrAccessor(IntPtr data, int count) : this(data.ToPointer(), count)
    {
    }

    public RangePtrAccessor(void* data, int count)
    {
        Data  = data;
        Count = count;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            return Unsafe.Read<T>((byte*) Data + sizeof(void*) * index);
        }
    }
}