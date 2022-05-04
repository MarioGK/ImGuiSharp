using System;

namespace ImGuiSharp.Structs;

public unsafe struct ImGuiStoragePairPtr
{
    public ImGuiStoragePair* NativePtr { get; }

    public ImGuiStoragePairPtr(ImGuiStoragePair* nativePtr)
    {
        NativePtr = nativePtr;
    }

    public ImGuiStoragePairPtr(IntPtr nativePtr)
    {
        NativePtr = (ImGuiStoragePair*) nativePtr;
    }

    public static implicit operator ImGuiStoragePairPtr(ImGuiStoragePair* nativePtr)
    {
        return new ImGuiStoragePairPtr(nativePtr);
    }

    public static implicit operator ImGuiStoragePair*(ImGuiStoragePairPtr wrappedPtr)
    {
        return wrappedPtr.NativePtr;
    }

    public static implicit operator ImGuiStoragePairPtr(IntPtr nativePtr)
    {
        return new ImGuiStoragePairPtr(nativePtr);
    }
}