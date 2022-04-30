using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiSharp.Structs;

// ReSharper disable once CheckNamespace
namespace ImGuiSharp
{
    public unsafe partial struct ImGuiMetricsConfig
    {
        public byte ShowStackTool;
        public byte ShowWindowsRects;
        public byte ShowWindowsBeginOrder;
        public byte ShowTablesRects;
        public byte ShowDrawCmdMesh;
        public byte ShowDrawCmdBoundingBoxes;
        public int ShowWindowsRectsType;
        public int ShowTablesRectsType;
    }
    public unsafe partial struct ImGuiMetricsConfigPtr
    {
        public ImGuiMetricsConfig* NativePtr { get; }
        public ImGuiMetricsConfigPtr(ImGuiMetricsConfig* nativePtr) => NativePtr = nativePtr;
        public ImGuiMetricsConfigPtr(IntPtr nativePtr) => NativePtr = (ImGuiMetricsConfig*)nativePtr;
        public static implicit operator ImGuiMetricsConfigPtr(ImGuiMetricsConfig* nativePtr) => new ImGuiMetricsConfigPtr(nativePtr);
        public static implicit operator ImGuiMetricsConfig* (ImGuiMetricsConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiMetricsConfigPtr(IntPtr nativePtr) => new ImGuiMetricsConfigPtr(nativePtr);
        public ref bool ShowStackTool => ref Unsafe.AsRef<bool>(&NativePtr->ShowStackTool);
        public ref bool ShowWindowsRects => ref Unsafe.AsRef<bool>(&NativePtr->ShowWindowsRects);
        public ref bool ShowWindowsBeginOrder => ref Unsafe.AsRef<bool>(&NativePtr->ShowWindowsBeginOrder);
        public ref bool ShowTablesRects => ref Unsafe.AsRef<bool>(&NativePtr->ShowTablesRects);
        public ref bool ShowDrawCmdMesh => ref Unsafe.AsRef<bool>(&NativePtr->ShowDrawCmdMesh);
        public ref bool ShowDrawCmdBoundingBoxes => ref Unsafe.AsRef<bool>(&NativePtr->ShowDrawCmdBoundingBoxes);
        public ref int ShowWindowsRectsType => ref Unsafe.AsRef<int>(&NativePtr->ShowWindowsRectsType);
        public ref int ShowTablesRectsType => ref Unsafe.AsRef<int>(&NativePtr->ShowTablesRectsType);
        public void Destroy()
        {
            ImGuiNative.ImGuiMetricsConfig_destroy((ImGuiMetricsConfig*)(NativePtr));
        }
    }
}
