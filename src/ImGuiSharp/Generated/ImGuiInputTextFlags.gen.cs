// ReSharper disable once CheckNamespace
namespace ImGui;
[System.Flags]
public enum ImGuiInputTextFlags
{
    ImGuiInputTextFlagsNone = 0,
    ImGuiInputTextFlagsCharsDecimal = 1 << 0,
    ImGuiInputTextFlagsCharsHexadecimal = 1 << 1,
    ImGuiInputTextFlagsCharsUppercase = 1 << 2,
    ImGuiInputTextFlagsCharsNoBlank = 1 << 3,
    ImGuiInputTextFlagsAutoSelectAll = 1 << 4,
    ImGuiInputTextFlagsEnterReturnsTrue = 1 << 5,
    ImGuiInputTextFlagsCallbackCompletion = 1 << 6,
    ImGuiInputTextFlagsCallbackHistory = 1 << 7,
    ImGuiInputTextFlagsCallbackAlways = 1 << 8,
    ImGuiInputTextFlagsCallbackCharFilter = 1 << 9,
    ImGuiInputTextFlagsAllowTabInput = 1 << 10,
    ImGuiInputTextFlagsCtrlEnterForNewLine = 1 << 11,
    ImGuiInputTextFlagsNoHorizontalScroll = 1 << 12,
    ImGuiInputTextFlagsAlwaysOverwrite = 1 << 13,
    ImGuiInputTextFlagsReadOnly = 1 << 14,
    ImGuiInputTextFlagsPassword = 1 << 15,
    ImGuiInputTextFlagsNoUndoRedo = 1 << 16,
    ImGuiInputTextFlagsCharsScientific = 1 << 17,
    ImGuiInputTextFlagsCallbackResize = 1 << 18,
    ImGuiInputTextFlagsCallbackEdit = 1 << 19,
}
