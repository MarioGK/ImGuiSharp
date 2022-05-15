// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct StbTexteditRow
{
        public float X0;
        public float X1;
        public float BaselineYDelta;
        public float Ymin;
        public float Ymax;
        public int NumChars;
}
public unsafe partial struct StbTexteditRowPtr
{
    public StbTexteditRow* NativePtr { get; }
    public StbTexteditRowPtr(StbTexteditRow* nativePtr) => NativePtr = nativePtr;
    public StbTexteditRowPtr(IntPtr nativePtr) => NativePtr = (StbTexteditRow*)nativePtr;
    public static implicit operator StbTexteditRowPtr(StbTexteditRow* nativePtr) => new (nativePtr);
    public static implicit operator StbTexteditRow* (StbTexteditRowPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator StbTexteditRowPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
