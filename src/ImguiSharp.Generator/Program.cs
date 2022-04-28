// See https://aka.ms/new-console-template for more information

using Cocona;
using ImGuiSharp.Generator;
using ImGuiSharp.Generator.Enumeration;

CoconaApp.Run((ManagedProject? project, string? output) =>
{
    project ??= ManagedProject.ImGuiSharp;
    var projectInfo = ProjectInfos.Infos.FirstOrDefault(x => x.ManagedProject == project);

    if (projectInfo == null)
    {
        Console.WriteLine($"Database does not contain any information about the project({project.ToString()}).");
        return;
    }

    output ??= Path.Join(AppContext.BaseDirectory, "..", "..", "..", "..", "..", projectInfo.ManagedProjectName,
                         "Generated");

    Console.WriteLine(projectInfo.ManagedProjectName);
    Console.WriteLine(output);


    var generator = new Generator(projectInfo, output);
    generator.Generate();

    //Generator.Generate(project, output);
});