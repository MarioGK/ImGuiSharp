using CppSharp.AST;
using CppSharp.Passes;

namespace ImGuiSharp.Generator.Passes;

public class TestEnum : TranslationUnitPass
{
    public override bool VisitEnumItemDecl(Enumeration.Item item)
    {
        item.Name = "as";
        return true;
    }
}