using System;
using System.Runtime.InteropServices;

namespace ImGuiSharp.Structs;

[StructLayout(LayoutKind.Explicit)]
public struct UnionValue
{
    [FieldOffset(0)] public int    ValueI32;
    [FieldOffset(0)] public float  ValueF32;
    [FieldOffset(0)] public IntPtr ValuePtr;
}