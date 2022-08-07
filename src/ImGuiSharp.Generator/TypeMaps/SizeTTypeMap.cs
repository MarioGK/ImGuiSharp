using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Types;

namespace ImGuiSharp.Generator.TypeMaps
{
    [TypeMap("size_t", GeneratorKind = GeneratorKind.CSharp)]
    public class SizeTTypeMap : TypeMap
    {
        public override CppSharp.AST.Type CSharpSignatureType(TypePrinterContext ctx)
        {
            return new CustomType("IntPtr");
        }
    }
}
