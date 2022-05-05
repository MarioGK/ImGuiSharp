namespace ImGuiSharp.Structs;

public unsafe readonly struct ImVector
{
    public readonly int Size;
    public readonly int Capacity;
    public readonly IntPtr Data;

    public ImVector(int size, int capacity, IntPtr data)
    {
        Size = size;
        Capacity = capacity;
        Data = data;
    }

    public ref T Ref<T>(int index)
    {
        return ref Unsafe.AsRef<T>((byte*) Data + index * Unsafe.SizeOf<T>());
    }

    public IntPtr Address<T>(int index)
    {
        return (IntPtr) ((byte*) Data + index * Unsafe.SizeOf<T>());
    }
}

public unsafe readonly struct ImVector<T>
{
    public readonly int Size;
    public readonly int Capacity;
    public readonly IntPtr Data;

    public ImVector(ImVector vector)
    {
        Size = vector.Size;
        Capacity = vector.Capacity;
        Data = vector.Data;
    }

    public ImVector(int size, int capacity, IntPtr data)
    {
        Size = size;
        Capacity = capacity;
        Data = data;
    }

    public ref T this[int index] => ref Unsafe.AsRef<T>((byte*) Data + index * Unsafe.SizeOf<T>());
}

public unsafe readonly struct ImPtrVector<T>
{
    public readonly int Size;
    public readonly int Capacity;
    public readonly IntPtr Data;
    private readonly int _stride;

    public ImPtrVector(ImVector vector, int stride)
        : this(vector.Size, vector.Capacity, vector.Data, stride)
    {
    }

    public ImPtrVector(int size, int capacity, IntPtr data, int stride)
    {
        Size = size;
        Capacity = capacity;
        Data = data;
        _stride = stride;
    }

    public T this[int index]
    {
        get
        {
            var address = (byte*) Data + index * _stride;
            var ret = Unsafe.Read<T>(&address);
            return ret;
        }
    }
}