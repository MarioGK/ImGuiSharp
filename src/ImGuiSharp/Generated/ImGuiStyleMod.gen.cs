// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiStyleMod
{
    public ImGuiStyleVar VarIdx;
    public union { int BackupInt[2]; float BackupFloat[2];} ;

}
