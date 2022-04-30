// ReSharper disable once CheckNamespace
namespace ImGuiSharp;

public unsafe partial struct ImGuiStoragePair
{
    public uint Key;
    public union { int val_i; float val_f; void* val_p;} ;

}
