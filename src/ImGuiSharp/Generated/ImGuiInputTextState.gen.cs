// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiInputTextState
{
        public uint ID;
        public int CurLenW;
        public int CurLenA;
        public ImVector TextW;
        public ImVector TextA;
        public ImVector InitialTextA;
        public byte TextAIsValid;
        public int BufCapacityA;
        public float ScrollX;
        public STB_TexteditState Stb;
        public float CursorAnim;
        public byte CursorFollow;
        public byte SelectedAllMouseLock;
        public byte Edited;
        public ImGuiInputTextFlags Flags;
}
public unsafe partial struct ImGuiInputTextStatePtr
{
    public ImGuiInputTextState* NativePtr { get; }
    public ImGuiInputTextStatePtr(ImGuiInputTextState* nativePtr) => NativePtr = nativePtr;
    public ImGuiInputTextStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextState*)nativePtr;
    public static implicit operator ImGuiInputTextStatePtr(ImGuiInputTextState* nativePtr) => new (nativePtr);
    public static implicit operator ImGuiInputTextState* (ImGuiInputTextStatePtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator ImGuiInputTextStatePtr(IntPtr nativePtr) => new (nativePtr);
}
