using ImguiSharp.Generator.Enumeration;

namespace ImguiSharp.Generator.Models;

public class ProjectInfo
{
    public NativeProject  NativeProject         { get; set; }
    public string         NativeProjectName     => NativeProject.ToString();
    public ManagedProject ManagedProject        { get; set; }
    public string         ManagedProjectName    => ManagedProject.ToString();
    public bool           ReferencesMainProject { get; set; }
    public string         ClassPrefix           { get; set; }

    public ProjectInfo()
    {
        ClassPrefix = ManagedProjectName.Replace("Sharp", "");
    }
}