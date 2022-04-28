using ImGuiSharp.Generator.Enumeration;
using ImGuiSharp.Generator.Models;

namespace ImGuiSharp.Generator;

public static class ProjectInfos
{
    public static readonly List<ProjectInfo> Infos = new()
    {
        new ProjectInfo
        {
            NativeProject         = NativeProject.cimgui,
            ManagedProject        = ManagedProject.ImGuiSharp,
            ReferencesMainProject = false
        },
        new ProjectInfo
        {
            NativeProject         = NativeProject.cimplot,
            ManagedProject        = ManagedProject.ImPlotSharp,
            ReferencesMainProject = true
        },
        new ProjectInfo
        {
            NativeProject         = NativeProject.cimnodes,
            ManagedProject        = ManagedProject.ImNodesSharp,
            ReferencesMainProject = true
        },
        new ProjectInfo
        {
            NativeProject         = NativeProject.cimguizmo,
            ManagedProject        = ManagedProject.ImGuizmoSharp,
            ReferencesMainProject = true
        }
    };
}