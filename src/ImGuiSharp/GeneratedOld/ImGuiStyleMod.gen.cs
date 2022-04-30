using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiSharp.Structs;

// ReSharper disable once CheckNamespace
namespace ImGuiSharp
{
    public unsafe partial struct ImGuiStyleMod
    {
        public ImGuiStyleVar VarIdx;
    }
    public unsafe partial struct ImGuiStyleModPtr
    {
        public ImGuiStyleMod* NativePtr { get; }
        public ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => NativePtr = nativePtr;
        public ImGuiStyleModPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleMod*)nativePtr;
        public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => new ImGuiStyleModPtr(nativePtr);
        public static implicit operator ImGuiStyleMod* (ImGuiStyleModPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiStyleModPtr(IntPtr nativePtr) => new ImGuiStyleModPtr(nativePtr);
        public ref ImGuiStyleVar VarIdx => ref Unsafe.AsRef<ImGuiStyleVar>(&NativePtr->VarIdx);
        public void Destroy()
        {
            ImGuiNative.ImGuiStyleMod_destroy((ImGuiStyleMod*)(NativePtr));
        }
    }
}
