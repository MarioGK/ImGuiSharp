// See https://aka.ms/new-console-template for more information

using CppSharp;
using ImGuiSharp.Generator;

ConsoleDriver.Run(new ImGui());

Console.WriteLine("Copying generated files...");
var filesToCopy   = Directory.EnumerateFiles("./GeneratedFiles", "*.cs");
var destDirectory = "../../../../ImGuiSharp";
foreach (var file in filesToCopy)
{
    var fileName    = Path.GetFileName(file);
    var destination = Path.Combine(destDirectory, fileName);
    File.Copy(file, destination, true);
}

Console.WriteLine("Finished!");