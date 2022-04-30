// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct StbUndoState
{
    public StbUndoRecord UndoRec[99];
    public ushort UndoChar[999];
    public short UndoPoint;
    public short RedoPoint;
    public int UndoCharPoint;
    public int RedoCharPoint;

}
