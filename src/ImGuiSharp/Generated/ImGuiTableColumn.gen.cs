// ReSharper disable once CheckNamespace
namespace ImGui;
public unsafe partial struct ImGuiTableColumn
{
        public ImGuiTableColumnFlags Flags;
        public float WidthGiven;
        public float MinX;
        public float MaxX;
        public float WidthRequest;
        public float WidthAuto;
        public float StretchWeight;
        public float InitStretchWeightOrWidth;
        public ImRect ClipRect;
        public uint UserID;
        public float WorkMinX;
        public float WorkMaxX;
        public float ItemWidth;
        public float ContentMaxXFrozen;
        public float ContentMaxXUnfrozen;
        public float ContentMaxXHeadersUsed;
        public float ContentMaxXHeadersIdeal;
        public short NameOffset;
        public sbyte DisplayOrder;
        public sbyte IndexWithinEnabledSet;
        public sbyte PrevEnabledColumn;
        public sbyte NextEnabledColumn;
        public sbyte SortOrder;
        public byte DrawChannelCurrent;
        public byte DrawChannelFrozen;
        public byte DrawChannelUnfrozen;
        public byte IsEnabled;
        public byte IsUserEnabled;
        public byte IsUserEnabledNextFrame;
        public byte IsVisibleX;
        public byte IsVisibleY;
        public byte IsRequestOutput;
        public byte IsSkipItems;
        public byte IsPreserveWidthAuto;
        public sbyte NavLayerCurrent;
        public byte AutoFitQueue;
        public byte CannotSkipItemsQueue;
        public byte SortDirection;
        public byte SortDirectionsAvailCount;
        public byte SortDirectionsAvailMask;
        public byte SortDirectionsAvailList;
}
