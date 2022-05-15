// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiInputTextCallbackData
{
        public ImGuiInputTextFlags EventFlag;
        public ImGuiInputTextFlags Flags;
        public void* UserData;
        public ushort EventChar;
        public ImGuiKey EventKey;
        public byte* Buf;
        public int BufTextLen;
        public int BufSize;
        public byte BufDirty;
        public int CursorPos;
        public int SelectionStart;
        public int SelectionEnd;
}
public unsafe partial struct ImGuiInputTextCallbackDataPtr
{
    public ImGuiInputTextCallbackData* NativePtr { get; }
    public ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => NativePtr = nativePtr;
    public ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextCallbackData*)nativePtr;
    public static implicit operator ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiInputTextCallbackData* (ImGuiInputTextCallbackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) => new (nativePtr);
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
