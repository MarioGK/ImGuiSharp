// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImVec1
{
        public float X;
}
public unsafe partial struct ImVec1Ptr
{
    public ImVec1* NativePtr { get; }
    public ImVec1Ptr(ImVec1* nativePtr) => NativePtr = nativePtr;
    public ImVec1Ptr(IntPtr nativePtr) => NativePtr = (ImVec1*)nativePtr;
    public static implicit operator ImVec1Ptr(ImVec1* nativePtr) => new (nativePtr);
    public static implicit operator ImVec1* (ImVec1Ptr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImVec1Ptr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
//TODO Functions
}
