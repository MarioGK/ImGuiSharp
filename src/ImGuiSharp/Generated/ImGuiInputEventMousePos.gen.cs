using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiSharp.Structs;

// ReSharper disable once CheckNamespace
namespace ImGuiSharp
{
    public unsafe partial struct ImGuiInputEventMousePos
    {
        public float PosX;
        public float PosY;
    }
    public unsafe partial struct ImGuiInputEventMousePosPtr
    {
        public ImGuiInputEventMousePos* NativePtr { get; }
        public ImGuiInputEventMousePosPtr(ImGuiInputEventMousePos* nativePtr) => NativePtr = nativePtr;
        public ImGuiInputEventMousePosPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventMousePos*)nativePtr;
        public static implicit operator ImGuiInputEventMousePosPtr(ImGuiInputEventMousePos* nativePtr) => new ImGuiInputEventMousePosPtr(nativePtr);
        public static implicit operator ImGuiInputEventMousePos* (ImGuiInputEventMousePosPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiInputEventMousePosPtr(IntPtr nativePtr) => new ImGuiInputEventMousePosPtr(nativePtr);
        public ref float PosX => ref Unsafe.AsRef<float>(&NativePtr->PosX);
        public ref float PosY => ref Unsafe.AsRef<float>(&NativePtr->PosY);
    }
}