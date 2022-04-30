// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiInputTextCallbackData
{
    public ImGuiInputTextFlags EventFlag;
    public ImGuiInputTextFlags Flags;
    public void* UserData;
    public ushort EventChar;
    public ImGuiKey EventKey;
    public char* Buf;
    public int BufTextLen;
    public int BufSize;
    public byte BufDirty;
    public int CursorPos;
    public int SelectionStart;
    public int SelectionEnd;

}
