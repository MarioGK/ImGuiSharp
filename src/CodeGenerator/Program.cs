using Cocona;
using CodeGenerator;

CoconaApp.Run((string project, string output) =>
{
    Generator.Generate(project, output);
});