// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

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
