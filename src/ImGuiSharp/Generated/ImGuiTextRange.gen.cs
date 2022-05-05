// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTextRange
{
        public byte* B;
        public byte* E;
}
public unsafe partial struct ImGuiTextRangePtr
{
    public ImGuiTextRange* NativePtr { get; }
    public ImGuiTextRangePtr(ImGuiTextRange* nativePtr) => NativePtr = nativePtr;
    public ImGuiTextRangePtr(IntPtr nativePtr) => NativePtr = (ImGuiTextRange*)nativePtr;
    public static implicit operator ImGuiTextRangePtr(ImGuiTextRange* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiTextRange* (ImGuiTextRangePtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiTextRangePtr(IntPtr nativePtr) => new (nativePtr);
}
