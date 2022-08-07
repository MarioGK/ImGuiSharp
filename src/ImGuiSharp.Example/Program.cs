// See https://aka.ms/new-console-template for more information

using ImGuiSharp;

Console.WriteLine("Hello, World!");
var open = false;
var io = ImGui.GetIO();
Console.WriteLine(io.DeltaTime);
//ImGui.Begin("Test", ref open, (int)ImGuiWindowFlags.ImGuiWindowFlagsModal);