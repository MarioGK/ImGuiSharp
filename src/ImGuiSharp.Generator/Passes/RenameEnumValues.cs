using CppSharp;
using CppSharp.Generators;
using CppSharp.Passes;

namespace ImGuiSharp.Generator.Passes;

public class RenameEnumValues : GeneratorOutputPass
{
    public override void VisitGeneratorOutput(GeneratorOutput output)
    {
        var enums = output.Outputs.SelectMany(i => i.FindBlocks(BlockKind.Enum));
        foreach (var enumeration in enums)
        {
            var a =enumeration;
        }
    }
}