using CppSharp;
using CppSharp.Generators;
using CppSharp.Passes;

namespace ImGuiSharp.Generator.Passes
{
    public class RenameCimguiClass : GeneratorOutputPass
    {
        public override void VisitGeneratorOutput(GeneratorOutput output)
        {
            var blocks = output.Outputs.SelectMany(i => i.FindBlocks(BlockKind.Unknown));
            foreach (var block in blocks)
            {
                block.Text.StringBuilder.Replace("cimgui_impl", "ImGui");
                block.Text.StringBuilder.Replace("cimgui", "ImGui");
            }
        }
    }
}
