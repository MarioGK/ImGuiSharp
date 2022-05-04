namespace CodeGenerator;

public class ProjectInfo
{
    public string NativeProjectName { get; set; }
    public string ManagedProjectName { get; set; }
    public bool ReferencesMainProject { get; set; }
    public string ClassPrefix { get; set; }
}