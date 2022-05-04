using ImGuiSharp.Generator.Enumeration;
using ImGuiSharp.Generator.Models;

namespace ImGuiSharp.Generator;

public static class ProjectInfos
{
    public static readonly ProjectInfo ImGuiSharp = new()
    {
        NativeProject = NativeProject.cimgui,
        ManagedProject = ManagedProject.ImGuiSharp,
        NameSpace = "ImGui"
    };

    public static readonly List<ProjectInfo> Infos = new()
    {
        ImGuiSharp,
        new ProjectInfo
        {
            NativeProject = NativeProject.cimplot,
            ManagedProject = ManagedProject.ImPlotSharp,
            NameSpace = "ImPlot"
        },
        new ProjectInfo
        {
            NativeProject = NativeProject.cimnodes,
            ManagedProject = ManagedProject.ImNodesSharp,
            NameSpace = "ImNodes"
        },
        new ProjectInfo
        {
            NativeProject = NativeProject.cimguizmo,
            ManagedProject = ManagedProject.ImGuizmoSharp,
            NameSpace = "ImGuizmo"
        }
    };
}