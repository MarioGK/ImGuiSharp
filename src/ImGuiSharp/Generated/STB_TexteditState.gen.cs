// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct STB_TexteditState
{
        public int cursor;
        public int select_start;
        public int select_end;
        public byte insert_mode;
        public int row_count_per_page;
        public byte cursor_at_end_of_line;
        public byte initialized;
        public byte has_preferred_x;
        public byte single_line;
        public byte padding1;
        public byte padding2;
        public byte padding3;
        public float preferred_x;
        public StbUndoState undostate;
}
