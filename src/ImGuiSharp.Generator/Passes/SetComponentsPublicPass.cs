using CppSharp;
using CppSharp.Generators;
using CppSharp.Passes;

namespace ImGuiSharp.Generator.Passes
{
    public class SetComponentsPublicPass : GeneratorOutputPass
    {
        public override void VisitGeneratorOutput(GeneratorOutput output)
        {
            var blocks = output.Outputs.SelectMany(i => i.FindBlocks(BlockKind.Unknown));
            foreach (var namespaceBlock in blocks)
            {
                switch (namespaceBlock.Parent.Kind)
                {
                    case BlockKind.Class:
                    {
                        foreach (var classBlock in namespaceBlock.Parent.Blocks)
                        {
                            ProcessClassBlock(classBlock);
                        }

                        break;
                    }
                    case BlockKind.InternalsClass:
                    {
                        foreach (var classBlock in namespaceBlock.Parent.Blocks)
                        {
                            ProcessClassBlock(classBlock.Parent);
                        }

                        break;
                    }
                }
            }
        }

        private static void ProcessClassBlock(Block block)
        {
            switch (block.Kind)
            {
                case BlockKind.Method:
                    ProcessClassMethod(block);
                    break;
                case BlockKind.InternalsClass:
                    ProcessInternalsClass(block);
                    break;
            }
        }

        private static void ProcessClassMethod(Block block)
        {
            var text = block.Text.StringBuilder.ToString();
            if (text.Contains("bool skipVTables"))
            {
                block.Text.StringBuilder.Replace("protected", "public");
            }
        }

        private static void ProcessInternalsClass(Block block)
        {
            foreach (var field in block.Blocks.Where(field => field.Kind is BlockKind.Field or BlockKind.InternalsClassMethod))
            {
                field.Text.StringBuilder.Replace("internal", "public");
            }
        }
    }
}
