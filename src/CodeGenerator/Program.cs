using Cocona;
using CodeGenerator;

CoconaApp.Run((string? project, string output) =>
{
    project ??= "cimgui";
    Generator.Generate(project, output);
});