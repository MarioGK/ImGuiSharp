// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct STB_TexteditState
{
    public int Cursor;
    public int SelectStart;
    public int SelectEnd;
    public byte InsertMode;
    public int RowCountPerPage;
    public byte CursorAtEndOfLine;
    public byte Initialized;
    public byte HasPreferredX;
    public byte SingleLine;
    public byte Padding1;
    public byte Padding2;
    public byte Padding3;
    public float PreferredX;
    public StbUndoState Undostate;

}
