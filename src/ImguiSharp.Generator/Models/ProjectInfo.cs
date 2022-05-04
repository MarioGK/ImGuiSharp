using ImGuiSharp.Generator.Enumeration;

namespace ImGuiSharp.Generator.Models;

public class ProjectInfo
{
    public ProjectInfo()
    {
        ClassPrefix = ManagedProjectName.Replace("Sharp", "");
    }

    public NativeProject NativeProject { get; set; }
    public string NativeProjectName => NativeProject.ToString();
    public ManagedProject ManagedProject { get; set; }
    public string ManagedProjectName => ManagedProject.ToString();

    public string NameSpace { get; set; }
    public string ClassPrefix { get; set; }
}