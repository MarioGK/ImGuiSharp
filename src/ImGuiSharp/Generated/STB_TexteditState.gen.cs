// ReSharper disable once CheckNamespace
namespace ImGui;
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
public unsafe partial struct STB_TexteditStatePtr
{
    public STB_TexteditState* NativePtr { get; }
    public STB_TexteditStatePtr(STB_TexteditState* nativePtr) => NativePtr = nativePtr;
    public STB_TexteditStatePtr(IntPtr nativePtr) => NativePtr = (STB_TexteditState*)nativePtr;
    public static implicit operator STB_TexteditStatePtr(STB_TexteditState* nativePtr) => new (nativePtr);
    public static implicit operator STB_TexteditState* (STB_TexteditStatePtr wrappedPtr) => wrappedPtr.NativePtr;
    public static implicit operator STB_TexteditStatePtr(IntPtr nativePtr) => new (nativePtr);
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
    //TODO ARRAY ACCESSOR
    //TODO ARRAY ACCESSOR
//TODO Functions
}
