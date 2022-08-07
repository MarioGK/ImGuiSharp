using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Passes;
using ImGuiSharp.Generator.Passes;

namespace ImGuiSharp.Generator;

public class ImGui : ILibrary
{
    public void Setup(Driver driver)
    {
        var options = driver.Options;
        options.GeneratorKind                     = GeneratorKind.CSharp;
        options.GenerateDefaultValuesForArguments = true;
        options.GenerateSequentialLayout          = true;
        options.GenerationOutputMode              = GenerationOutputMode.FilePerModule;
        options.OutputDir                         = "./GeneratedFiles";

        var module = options.AddModule("cimgui");
        module.OutputNamespace = "ImGuiSharp";
        module.Defines.Add("CIMGUI_DEFINE_ENUMS_AND_STRUCTS");
        //module.IncludeDirs.Add("../native/cimgui");
        module.IncludeDirs.Add(@"F:\Projects\ImGuiSharp\native\cimgui");
        module.Headers.Add("cimgui.h");
    }

    public void SetupPasses(Driver driver)
    {
        var translationUnit = driver.Context.TranslationUnitPasses;
        
        translationUnit.RenameDeclsUpperCase(RenameTargets.Property);
        translationUnit.RenameDeclsUpperCase(RenameTargets.Class);

        translationUnit.AddPass(new FunctionToInstanceMethodPass());
        translationUnit.AddPass(new CheckFlagEnumsPass());
        translationUnit.AddPass(new MakeProtectedNestedTypesPublicPass());
        translationUnit.AddPass(new SpecializationMethodsWithDependentPointersPass());
        translationUnit.AddPass(new CheckDuplicatedNamesPass());
        
        translationUnit.AddPass(new ConstructorToConversionOperatorPass());
        translationUnit.AddPass(new FixDefaultParamValuesOfOverridesPass());
        translationUnit.AddPass(new HandleDefaultParamValuesPass());
        
        var generatorOutput = driver.Context.GeneratorOutputPasses;
        generatorOutput.AddPass(new RenameCimguiClass());
        generatorOutput.AddPass(new RenameEnumValues());
        generatorOutput.AddPass(new SetComponentsPublicPass());
    }

    public void Preprocess(Driver driver, ASTContext ctx)
    {
        foreach (var decl in ctx.FindDecl<Declaration>("GImGui"))
        {
            decl.Ignore = true;
        }

        // Fix incorrect indirect value passes.
        foreach (var parameter in from translationUnit in ctx.TranslationUnits
                                  from function in translationUnit.Functions
                                  from parameter in function.Parameters
                                  where parameter.DebugText.Contains("const ImVec4")
                                  select parameter)
        {
            parameter.IsIndirect = false;
        }

        // Remove Prefixes
        foreach (var unit in ctx.TranslationUnits)
        {
            foreach (var enumeration in unit.Enums)
            {
                var a = enumeration.Name;
            }
            
            foreach (var func in unit.Functions)
            {
                func.Name = GetNameWithoutPrefix(func.Name);
            }

            RecursiveRemovePrefix(unit.Namespaces, ctx);
        }
    }
    
    private void RecursiveRemovePrefix(IEnumerable<Namespace> namespaces, ASTContext ctx)
    {
        foreach (var ns in namespaces)
        {
            RecursiveRemovePrefix(ns.Namespaces, ctx);
            foreach (var cls in ns.Classes)
            {
                cls.Name = GetNameWithoutPrefix(cls.Name);
            }
        }
    }
    private string GetNameWithoutPrefix(string name) => name.TrimStart("ig".ToCharArray());

    public void Postprocess(Driver driver, ASTContext ctx)
    {
        IgnoreProperty("ImVectorImTextureID", "Data", ctx);
    }

    private void IgnoreProperty(string className, string propertyName, ASTContext ctx)
    {
        try
        {
            var cls          = ctx.FindCompleteClass(className);
            var dataProperty = cls.Properties.First(x => x.OriginalName == propertyName);
            dataProperty.Ignore = true;
        }
        catch (Exception)
        {
            Console.WriteLine("Could not ignore property {0}.{1}", className, propertyName);
        }
    }

    public void GenerateCode(Driver driver, List<GeneratorOutput> outputs)
    {
    }
}