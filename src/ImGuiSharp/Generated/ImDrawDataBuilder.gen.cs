// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImDrawDataBuilder
{
        public ImVector Layers0;
        public ImVector Layers1;
        public ImVector Layers2;
}
public unsafe partial struct ImDrawDataBuilderPtr
{
    public ImDrawDataBuilder* NativePtr { get; }
    public ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => NativePtr = nativePtr;
    public ImDrawDataBuilderPtr(IntPtr nativePtr) => NativePtr = (ImDrawDataBuilder*)nativePtr;
    public static implicit operator ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => new (nativePtr);
    public static implicit operator ImDrawDataBuilder* (ImDrawDataBuilderPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImDrawDataBuilderPtr(IntPtr nativePtr) => new (nativePtr);
    public RangeAccessor<ImVector> Layers => new (&NativePtr->Layers0, 2);
//TODO Functions
}
