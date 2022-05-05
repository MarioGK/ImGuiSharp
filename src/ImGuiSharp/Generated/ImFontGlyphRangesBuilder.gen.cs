// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImFontGlyphRangesBuilder
{
        public ImVector UsedChars;
}
public unsafe partial struct ImFontGlyphRangesBuilderPtr
{
    public ImFontGlyphRangesBuilder* NativePtr { get; }
    public ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* nativePtr) => NativePtr = nativePtr;
    public ImFontGlyphRangesBuilderPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyphRangesBuilder*)nativePtr;
    public static implicit operator ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* nativePtr) => new (nativePtr);
    public static implicit operator ImFontGlyphRangesBuilder* (ImFontGlyphRangesBuilderPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImFontGlyphRangesBuilderPtr(IntPtr nativePtr) => new (nativePtr);
}
