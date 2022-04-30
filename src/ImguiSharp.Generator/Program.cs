// See https://aka.ms/new-console-template for more information

using Cocona;
using ImGuiSharp.Generator;
using ImGuiSharp.Generator.Enumeration;
using ImGuiSharp.Generator.Helpers;

CoconaApp.Run((ManagedProject? project, string? output) =>
{
    using var timer = new MeasureTimer("Whole process");
    project ??= ManagedProject.ImGuiSharp;
    var projectInfo = ProjectInfos.Infos.FirstOrDefault(x => x.ManagedProject == project);

    if (projectInfo == null)
    {
        Console.WriteLine($"Database does not contain any information about the project({project.ToString()}).");
        return;
    }

    var root = Path.Join(AppContext.BaseDirectory, "..", "..", "..", "..", "..");

    output ??= Path.Join(root, "src" , projectInfo.ManagedProjectName, "Generated");

    Console.WriteLine(projectInfo.ManagedProjectName);
    Console.WriteLine(output);


    var generator = new Generator(projectInfo, output);
    generator.Generate();

    //Generator.Generate(project, output);
});