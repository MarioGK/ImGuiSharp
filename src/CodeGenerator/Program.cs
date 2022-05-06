using System;
using System.IO;
using System.Linq;
using Cocona;
using CodeGenerator;

CoconaApp.Run((string? project, string? output) =>
{
    project ??= "cimgui";
    
    var projectInfo = Generator.ProjectInfos.FirstOrDefault(x => x.NativeProjectName == project);
    
    var root = Path.Join(AppContext.BaseDirectory, "..", "..", "..", "..", "..");

    output ??= Path.Join(root, "src" , projectInfo!.ManagedProjectName, "Generated");
    
    Generator.Generate(project, output);
});