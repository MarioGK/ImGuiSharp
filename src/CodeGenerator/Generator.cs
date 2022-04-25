using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CodeGenerator.Definitions;

namespace CodeGenerator;

internal static class Generator
{
    private static readonly List<ProjectInfo> ProjectInfos = new()
    {
        new ProjectInfo
        {
            NativeProjectName     = "cimgui",
            ClassPrefix           = "ImGui",
            ManagedProjectName    = "ImGuiSharp",
            ReferencesMainProject = false,
        },
        new ProjectInfo
        {
            NativeProjectName     = "cimplot",
            ClassPrefix           = "ImPlot",
            ManagedProjectName    = "ImPlotSharp",
            ReferencesMainProject = true,
        },
        new ProjectInfo
        {
            NativeProjectName     = "cimnodes",
            ClassPrefix           = "ImNodes",
            ManagedProjectName    = "ImNodesSharp",
            ReferencesMainProject = true,
        },
        new ProjectInfo
        {
            NativeProjectName     = "cimguizmo",
            ClassPrefix           = "ImGuizmo",
            ManagedProjectName    = "ImGuizmoSharp",
            ReferencesMainProject = true,
        },
    };
    
    
    internal static void Generate(string project, string output)
    {
        var projectInfo = ProjectInfos.FirstOrDefault(x => x.NativeProjectName == project);

        if (projectInfo == null)
        {
            Console.WriteLine($"{project} is not currently supported");
            return;
        }

        //Going to root folder to get definitions
        var definitionsPath = Path.Combine(AppContext.BaseDirectory, "defs", $"{projectInfo.NativeProjectName}");
        var defs            = new DefinitionsParser();
        defs.LoadFrom(definitionsPath);

        Console.WriteLine($"Outputting generated code files to {output}.");

        foreach (var ed in defs.Enums)
        {
            using var writer = new CSharpCodeWriter(Path.Combine(output, ed.FriendlyName + ".gen.cs"));
            writer.WriteLine("// ReSharper disable once CheckNamespace");
            writer.PushBlock($"namespace {projectInfo.ManagedProjectName}");
            if (ed.FriendlyName.Contains("Flags"))
            {
                writer.WriteLine("[System.Flags]");
            }
            writer.PushBlock($"public enum {ed.FriendlyName}");
            foreach (var member in ed.Members)
            {
                var sanitizedName  = ed.SanitizeNames(member.Name);
                var sanitizedValue = ed.SanitizeNames(member.Value);
                writer.WriteLine($"{sanitizedName} = {sanitizedValue},");
            }
            writer.PopBlock();
            writer.PopBlock();
        }

        foreach (var td in defs.Types)
        {
            if (TypeInfo.CustomDefinedTypes.Contains(td.Name)) { continue; }

            using var writer = new CSharpCodeWriter(Path.Combine(output, td.Name + ".gen.cs"));
            writer.Using("System");
            writer.Using("System.Numerics");
            writer.Using("System.Runtime.CompilerServices");
            writer.Using("System.Text");
            if (projectInfo.ReferencesMainProject)
            {
                writer.Using("ImGuiSharp");
            }
            writer.Using("ImGuiSharp.Structs");
            writer.WriteLine(string.Empty);
            writer.WriteLine("// ReSharper disable once CheckNamespace");
            writer.PushBlock($"namespace {projectInfo.ManagedProjectName}");

            writer.PushBlock($"public unsafe partial struct {td.Name}");
            foreach (var field in td.Fields)
            {
                var typeStr = GetTypeString(field.Type, field.IsFunctionPointer);

                if (field.ArraySize != 0)
                {
                    if (TypeInfo.LegalFixedTypes.Contains(typeStr))
                    {
                        writer.WriteLine($"public fixed {typeStr} {field.Name}[{field.ArraySize}];");
                    }
                    else
                    {
                        for (var i = 0; i < field.ArraySize; i++)
                        {
                            writer.WriteLine($"public {typeStr} {field.Name}_{i};");
                        }
                    }
                }
                else
                {
                    writer.WriteLine($"public {typeStr} {field.Name};");
                }
            }
            writer.PopBlock();

            var ptrTypeName = td.Name + "Ptr";
            writer.PushBlock($"public unsafe partial struct {ptrTypeName}");
            writer.WriteLine($"public {td.Name}* NativePtr {{ get; }}");
            writer.WriteLine($"public {ptrTypeName}({td.Name}* nativePtr) => NativePtr = nativePtr;");
            writer.WriteLine($"public {ptrTypeName}(IntPtr nativePtr) => NativePtr = ({td.Name}*)nativePtr;");
            writer.WriteLine($"public static implicit operator {ptrTypeName}({td.Name}* nativePtr) => new {ptrTypeName}(nativePtr);");
            writer.WriteLine($"public static implicit operator {td.Name}* ({ptrTypeName} wrappedPtr) => wrappedPtr.NativePtr;");
            writer.WriteLine($"public static implicit operator {ptrTypeName}(IntPtr nativePtr) => new {ptrTypeName}(nativePtr);");

            foreach (var field in td.Fields)
            {
                var typeStr = GetTypeString(field.Type, field.IsFunctionPointer);
                var rawType = typeStr;

                if (TypeInfo.WellKnownFieldReplacements.TryGetValue(field.Type, out var wellKnownFieldType))
                {
                    typeStr = wellKnownFieldType;
                }

                if (field.ArraySize != 0)
                {
                    var addrTarget = TypeInfo.LegalFixedTypes.Contains(rawType) ? $"NativePtr->{field.Name}" : $"&NativePtr->{field.Name}_0";
                    writer.WriteLine($"public RangeAccessor<{typeStr}> {field.Name} => new RangeAccessor<{typeStr}>({addrTarget}, {field.ArraySize});");
                }
                else if (typeStr.Contains("ImVector"))
                {
                    var vectorElementType = GetTypeString(field.TemplateType, false);

                    if (TypeInfo.WellKnownTypes.TryGetValue(vectorElementType, out var wellKnown))
                    {
                        vectorElementType = wellKnown;
                    }

                    if (GetWrappedType(vectorElementType + "*", out var wrappedElementType))
                    {
                        writer.WriteLine($"public ImPtrVector<{wrappedElementType}> {field.Name} => new ImPtrVector<{wrappedElementType}>(NativePtr->{field.Name}, Unsafe.SizeOf<{vectorElementType}>());");
                    }
                    else
                    {
                        if (GetWrappedType(vectorElementType, out wrappedElementType))
                        {
                            vectorElementType = wrappedElementType;
                        }
                        writer.WriteLine($"public ImVector<{vectorElementType}> {field.Name} => new ImVector<{vectorElementType}>(NativePtr->{field.Name});");
                    }
                }
                else
                {
                    if (typeStr.Contains('*') && !typeStr.Contains("ImVector"))
                    {
                        if (GetWrappedType(typeStr, out var wrappedTypeName))
                        {
                            writer.WriteLine($"public {wrappedTypeName} {field.Name} => new {wrappedTypeName}(NativePtr->{field.Name});");
                        }
                        else if (typeStr == "byte*" && IsStringFieldName(field.Name))
                        {
                            writer.WriteLine($"public NullTerminatedString {field.Name} => new NullTerminatedString(NativePtr->{field.Name});");
                        }
                        else
                        {
                            writer.WriteLine($"public IntPtr {field.Name} {{ get => (IntPtr)NativePtr->{field.Name}; set => NativePtr->{field.Name} = ({typeStr})value; }}");
                        }
                    }
                    else
                    {
                        writer.WriteLine($"public ref {typeStr} {field.Name} => ref Unsafe.AsRef<{typeStr}>(&NativePtr->{field.Name});");
                    }
                }
            }

            foreach (var fd in defs.Functions)
            {
                foreach (var overload in fd.Overloads)
                {
                    if (overload.StructName != td.Name)
                    {
                        continue;
                    }

                    if (overload.IsConstructor)
                    {
                        // TODO: Emit a static function on the type that invokes the native constructor.
                        // Also, add a "Dispose" function or similar.
                        continue;
                    }

                    var exportedName = overload.ExportedName;
                    if (exportedName.StartsWith("ig"))
                    {
                        exportedName = exportedName.Substring(2, exportedName.Length - 2);
                    }
                    if (exportedName.Contains('~')) { continue; }
                    if (overload.Parameters.Any(tr => tr.Type.Contains('('))) { continue; } // TODO: Parse function pointer parameters.

                    var hasVaList = false;
                    foreach (var p in overload.Parameters)
                    {
                        var paramType = GetTypeString(p.Type, p.IsFunctionPointer);
                        if (p.Name == "...") { continue; }

                        if (paramType != "va_list")
                        {
                            continue;
                        }

                        hasVaList = true;
                        break;
                    }
                    if (hasVaList) { continue; }

                    var orderedDefaults = overload.DefaultValues.OrderByDescending(
                     kvp => GetIndex(overload.Parameters, kvp.Key)).ToArray();

                    for (var i = overload.DefaultValues.Count; i >= 0; i--)
                    {
                        var defaults = new Dictionary<string, string>();
                        for (var j = 0; j < i; j++)
                        {
                            defaults.Add(orderedDefaults[j].Key, orderedDefaults[j].Value);
                        }
                        EmitOverload(writer, overload, defaults, "NativePtr", projectInfo.ClassPrefix);
                    }
                }
            }
            writer.PopBlock();

            writer.PopBlock();
        }

        using (var writer = new CSharpCodeWriter(Path.Combine(output, $"{projectInfo.ClassPrefix}Native.gen.cs")))
        {
            writer.Using("System");
            writer.Using("System.Numerics");
            writer.Using("System.Runtime.InteropServices");
            if (projectInfo.ReferencesMainProject)
            {
                writer.Using("ImGuiSharp");
            }
            writer.Using("ImGuiSharp.Structs");
            writer.WriteLine(string.Empty);
            writer.WriteLine("// ReSharper disable once CheckNamespace");
            writer.PushBlock($"namespace {projectInfo.ManagedProjectName}");
            writer.PushBlock($"public static unsafe partial class {projectInfo.ClassPrefix}Native");
            foreach (var fd in defs.Functions)
            {
                foreach (var overload in fd.Overloads)
                {
                    var exportedName = overload.ExportedName;
                    if (exportedName.Contains('~')) { continue; }
                    if (exportedName.Contains("ImVector_")) { continue; }
                    if (exportedName.Contains("ImChunkStream_")) { continue; }

                    if (overload.Parameters.Any(tr => tr.Type.Contains('('))) { continue; } // TODO: Parse function pointer parameters.

                    var ret = GetTypeString(overload.ReturnType, false);

                    var hasVaList  = false;
                    var paramParts = new List<string>();
                    foreach (var p in overload.Parameters)
                    {
                        var paramType = GetTypeString(p.Type, p.IsFunctionPointer);
                        if (p.ArraySize != 0)
                        {
                            paramType = paramType + "*";
                        }

                        if (p.Name == "...") { continue; }

                        paramParts.Add($"{paramType} {CorrectIdentifier(p.Name)}");

                        if (paramType == "va_list")
                        {
                            hasVaList = true;
                            break;
                        }
                    }

                    if (hasVaList) { continue; }

                    var parameters = string.Join(", ", paramParts);

                    var isUdtVariant = exportedName.Contains("nonUDT");
                    var methodName = isUdtVariant
                                         ? exportedName[..exportedName.IndexOf("_nonUDT", StringComparison.Ordinal)]
                                         : exportedName;

                    writer.WriteLine(isUdtVariant
                                         ? $"[DllImport(\"{projectInfo.NativeProjectName}\", CallingConvention = CallingConvention.Cdecl, EntryPoint = \"{exportedName}\")]"
                                         : $"[DllImport(\"{projectInfo.NativeProjectName}\", CallingConvention = CallingConvention.Cdecl)]");
                    writer.WriteLine($"public static extern {ret} {methodName}({parameters});");
                }
            }
            writer.PopBlock();
            writer.PopBlock();
        }

        using (var writer = new CSharpCodeWriter(Path.Combine(output, $"{projectInfo.ClassPrefix}.gen.cs")))
        {
            writer.Using("System");
            writer.Using("System.Numerics");
            writer.Using("System.Runtime.InteropServices");
            writer.Using("System.Text");
            if (projectInfo.ReferencesMainProject)
            {
                writer.Using("ImGuiSharp");
                
            }
            writer.Using("ImGuiSharp.Structs");
            writer.WriteLine(string.Empty);
            writer.WriteLine("// ReSharper disable once CheckNamespace");
            writer.PushBlock($"namespace {projectInfo.ManagedProjectName}");
            writer.PushBlock($"public static unsafe partial class {projectInfo.ClassPrefix}");
            foreach (var fd in defs.Functions)
            {
                if (TypeInfo.SkippedFunctions.Contains(fd.Name)) { continue; }

                foreach (var overload in fd.Overloads)
                {
                    var exportedName = overload.ExportedName;
                    if (exportedName.StartsWith("ig"))
                    {
                        exportedName = exportedName.Substring(2, exportedName.Length - 2);
                    }
                    if (exportedName.Contains("~")) { continue; }
                    if (overload.Parameters.Any(tr => tr.Type.Contains('('))) { continue; } // TODO: Parse function pointer parameters.

                    var hasVaList = false;
                    foreach (var p in overload.Parameters)
                    {
                        var paramType = GetTypeString(p.Type, p.IsFunctionPointer);
                        if (p.Name == "...") { continue; }

                        if (paramType != "va_list")
                        {
                            continue;
                        }

                        hasVaList = true;
                        break;
                    }
                    if (hasVaList) { continue; }

                    var orderedDefaults = overload.DefaultValues.OrderByDescending(
                     kvp => GetIndex(overload.Parameters, kvp.Key)).ToArray();

                    for (var i = overload.DefaultValues.Count; i >= 0; i--)
                    {
                        if (overload.IsMemberFunction) { continue; }
                        var defaults = new Dictionary<string, string>();
                        for (var j = 0; j < i; j++)
                        {
                            defaults.Add(orderedDefaults[j].Key, orderedDefaults[j].Value);
                        }
                        EmitOverload(writer, overload, defaults, null, projectInfo.ClassPrefix);
                    }
                }
            }
            writer.PopBlock();
            writer.PopBlock();
        }

        foreach (var method in defs.Variants)
        {
            foreach (var variant in method.Value.Parameters)
            {
                if (!variant.Used)
                {
                    Console.WriteLine($"Error: Variants targetting parameter {variant.Name} with type {variant.OriginalType} could not be applied to method {method.Key}.");
                }
            }
        }
    }

    private static bool IsStringFieldName(string name)
    {
        return Regex.IsMatch(name, ".*Filename.*") || Regex.IsMatch(name, ".*Name");
    }

    private static string GetImVectorElementType(string typeStr)
    {
        var start  = typeStr.IndexOf('<') + 1;
        var end    = typeStr.IndexOf('>');
        var length = end - start;
        return typeStr.Substring(start, length);
    }

    private static int GetIndex(TypeReference[] parameters, string key)
    {
        for (var i = 0; i < parameters.Length; i++)
        {
            if (key == parameters[i].Name) { return i; }
        }

        throw new InvalidOperationException();
    }

    private static void EmitOverload(
        CSharpCodeWriter           writer,
        OverloadDefinition         overload,
        Dictionary<string, string> defaultValues,
        string                     selfName,
        string                     classPrefix)
    {
        if (overload.Parameters.Where(tr => tr.Name.EndsWith("_begin") || tr.Name.EndsWith("_end"))
                    .Any(tr => !defaultValues.ContainsKey(tr.Name)))
        {
            return;
        }

        Debug.Assert(!overload.IsMemberFunction || selfName != null);

        var nativeRet     = GetTypeString(overload.ReturnType, false);
        var isWrappedType = GetWrappedType(nativeRet, out var safeRet);
        if (!isWrappedType)
        {
            safeRet = GetSafeType(overload.ReturnType);
        }

        var    invocationArgs       = new List<string>();
        var    marshalledParameters = new MarshalledParameter[overload.Parameters.Length];
        var    preCallLines         = new List<string>();
        var    postCallLines        = new List<string>();
        var    byRefParams          = new List<string>();
        var    selfIndex            = -1;
        var    pOutIndex            = -1;
        string overrideRet          = null;
        for (var i = 0; i < overload.Parameters.Length; i++)
        {
            var tr = overload.Parameters[i];
            switch (tr.Name)
            {
                case "self":
                    selfIndex = i;
                    continue;
                case "...":
                    continue;
            }

            var correctedIdentifier = CorrectIdentifier(tr.Name);
            var nativeTypeName      = GetTypeString(tr.Type, tr.IsFunctionPointer);
            if (correctedIdentifier == "pOut" && overload.ReturnType == "void")
            {
                pOutIndex   = i;
                overrideRet = nativeTypeName.TrimEnd('*');
                preCallLines.Add($"{overrideRet} __retval;");
                continue;
            }
            if (tr.Type == "char*")
            {
                var textToEncode = correctedIdentifier;
                var hasDefault   = false;
                if (defaultValues.TryGetValue(tr.Name, out var defaultStrVal))
                {
                    hasDefault = true;
                    if (!CorrectDefaultValue(defaultStrVal, tr, out var correctedDefault))
                    {
                        correctedDefault = defaultStrVal;
                    }

                    textToEncode = correctedDefault;
                }

                var nativeArgName = "native_" + tr.Name;
                marshalledParameters[i] = new MarshalledParameter("string", false, nativeArgName, hasDefault);

                if (textToEncode == "null")
                {
                    preCallLines.Add($"byte* {nativeArgName} = null;");
                }
                else
                {
                    preCallLines.Add($"byte* {nativeArgName};");
                    preCallLines.Add($"int {correctedIdentifier}_byteCount = 0;");
                    if (!hasDefault)
                    {
                        preCallLines.Add($"if ({textToEncode} != null)");
                        preCallLines.Add("{");
                    }
                    preCallLines.Add($"    {correctedIdentifier}_byteCount = Encoding.UTF8.GetByteCount({textToEncode});");
                    preCallLines.Add($"    if ({correctedIdentifier}_byteCount > Util.StackAllocationSizeLimit)");
                    preCallLines.Add($"    {{");
                    preCallLines.Add($"        {nativeArgName} = Util.Allocate({correctedIdentifier}_byteCount + 1);");
                    preCallLines.Add($"    }}");
                    preCallLines.Add($"    else");
                    preCallLines.Add($"    {{");
                    preCallLines.Add($"        byte* {nativeArgName}_stackBytes = stackalloc byte[{correctedIdentifier}_byteCount + 1];");
                    preCallLines.Add($"        {nativeArgName} = {nativeArgName}_stackBytes;");
                    preCallLines.Add($"    }}");
                    preCallLines.Add($"    int {nativeArgName}_offset = Util.GetUtf8({textToEncode}, {nativeArgName}, {correctedIdentifier}_byteCount);");
                    preCallLines.Add($"    {nativeArgName}[{nativeArgName}_offset] = 0;");

                    if (!hasDefault)
                    {
                        preCallLines.Add("}");
                        preCallLines.Add($"else {{ {nativeArgName} = null; }}");
                    }

                    postCallLines.Add($"if ({correctedIdentifier}_byteCount > Util.StackAllocationSizeLimit)");
                    postCallLines.Add($"{{");
                    postCallLines.Add($"    Util.Free({nativeArgName});");
                    postCallLines.Add($"}}");
                }
            }
            else if (defaultValues.TryGetValue(tr.Name, out var defaultVal))
            {
                if (!CorrectDefaultValue(defaultVal, tr, out var correctedDefault))
                {
                    correctedDefault = defaultVal;
                }
                marshalledParameters[i] = new MarshalledParameter(nativeTypeName, false, correctedIdentifier, true);
                preCallLines.Add($"{nativeTypeName} {correctedIdentifier} = {correctedDefault};");
            }
            else if (tr.Type == "char* []")
            {
                var nativeArgName = "native_" + tr.Name;
                marshalledParameters[i] = new MarshalledParameter("string[]", false, nativeArgName, false);

                preCallLines.Add($"int* {correctedIdentifier}_byteCounts = stackalloc int[{correctedIdentifier}.Length];");

                preCallLines.Add($"int {correctedIdentifier}_byteCount = 0;");
                preCallLines.Add($"for (int i = 0; i < {correctedIdentifier}.Length; i++)");
                preCallLines.Add("{");
                preCallLines.Add($"    string s = {correctedIdentifier}[i];");
                preCallLines.Add($"    {correctedIdentifier}_byteCounts[i] = Encoding.UTF8.GetByteCount(s);");
                preCallLines.Add($"    {correctedIdentifier}_byteCount += {correctedIdentifier}_byteCounts[i] + 1;");
                preCallLines.Add("}");

                preCallLines.Add($"byte* {nativeArgName}_data = stackalloc byte[{correctedIdentifier}_byteCount];");

                preCallLines.Add("int offset = 0;");
                preCallLines.Add($"for (int i = 0; i < {correctedIdentifier}.Length; i++)");
                preCallLines.Add("{");
                preCallLines.Add($"    string s = {correctedIdentifier}[i];");
                preCallLines.Add($"    fixed (char* sPtr = s)");
                preCallLines.Add("    {");
                preCallLines.Add($"        offset += Encoding.UTF8.GetBytes(sPtr, s.Length, {nativeArgName}_data + offset, {correctedIdentifier}_byteCounts[i]);");
                preCallLines.Add($"        {nativeArgName}_data[offset] = 0;");
                preCallLines.Add($"        offset += 1;");
                preCallLines.Add("    }");
                preCallLines.Add("}");

                preCallLines.Add($"byte** {nativeArgName} = stackalloc byte*[{correctedIdentifier}.Length];");
                preCallLines.Add("offset = 0;");
                preCallLines.Add($"for (int i = 0; i < {correctedIdentifier}.Length; i++)");
                preCallLines.Add("{");
                preCallLines.Add($"    {nativeArgName}[i] = &{nativeArgName}_data[offset];");
                preCallLines.Add($"    offset += {correctedIdentifier}_byteCounts[i] + 1;");
                preCallLines.Add("}");
            }
            else if (tr.Type == "bool")
            {
                var nativeArgName = "native_" + tr.Name;
                marshalledParameters[i] = new MarshalledParameter("bool", false, nativeArgName, false);
                preCallLines.Add($"byte {nativeArgName} = {tr.Name} ? (byte)1 : (byte)0;");
            }
            else if (tr.Type == "bool*")
            {
                var nativeArgName = "native_" + tr.Name;
                marshalledParameters[i] = new MarshalledParameter("ref bool", false, nativeArgName, false);
                preCallLines.Add($"byte {nativeArgName}_val = {correctedIdentifier} ? (byte)1 : (byte)0;");
                preCallLines.Add($"byte* {nativeArgName} = &{nativeArgName}_val;");
                postCallLines.Add($"{correctedIdentifier} = {nativeArgName}_val != 0;");
            }
            else if (tr.Type == "void*" || tr.Type == "ImWchar*")
            {
                var nativePtrTypeName = tr.Type == "void*" ? "void*" : "ushort*";
                var nativeArgName     = "native_" + tr.Name;
                marshalledParameters[i] = new MarshalledParameter("IntPtr", false, nativeArgName, false);
                preCallLines.Add($"{nativePtrTypeName} {nativeArgName} = ({nativePtrTypeName}){correctedIdentifier}.ToPointer();");
            }
            else if (GetWrappedType(tr.Type, out var wrappedParamType)
                  && !TypeInfo.WellKnownTypes.ContainsKey(tr.Type)
                  && !TypeInfo.WellKnownTypes.ContainsKey(tr.Type.Substring(0, tr.Type.Length - 1)))
            {
                marshalledParameters[i] = new MarshalledParameter(wrappedParamType, false, "native_" + tr.Name, false);
                var nativeArgName = "native_" + tr.Name;
                marshalledParameters[i] = new MarshalledParameter(wrappedParamType, false, nativeArgName, false);
                preCallLines.Add($"{tr.Type} {nativeArgName} = {correctedIdentifier}.NativePtr;");
            }
            else if ((tr.Type.EndsWith("*") || tr.Type.Contains("[") || tr.Type.EndsWith("&")) && tr.Type != "void*" && tr.Type != "ImGuiContext*" && tr.Type != "ImPlotContext*"&& tr.Type != "EditorContext*")
            {
                string nonPtrType;
                if (tr.Type.Contains("["))
                {
                    var wellKnown = TypeInfo.WellKnownTypes[tr.Type];
                    nonPtrType = GetTypeString(wellKnown.Substring(0, wellKnown.Length - 1), false);
                }
                else
                {
                    nonPtrType = GetTypeString(tr.Type.Substring(0, tr.Type.Length - 1), false);
                }
                var nativeArgName = "native_" + tr.Name;
                var isOutParam = tr.Name.Contains("out_") || tr.Name == "out";
                var direction = isOutParam ? "out" : "ref";
                marshalledParameters[i] = new MarshalledParameter($"{direction} {nonPtrType}", true, nativeArgName, false);
                marshalledParameters[i].PinTarget = CorrectIdentifier(tr.Name);
            }
            else
            {
                marshalledParameters[i] = new MarshalledParameter(nativeTypeName, false, correctedIdentifier, false);
            }

            if (!marshalledParameters[i].HasDefaultValue)
            {
                invocationArgs.Add($"{marshalledParameters[i].MarshalledType} {correctedIdentifier}");
            }
        }

        var invocationList = string.Join(", ", invocationArgs);
        var friendlyName   = overload.FriendlyName;

        var staticPortion = selfName == null ? "static " : string.Empty;
        writer.PushBlock($"public {staticPortion}{overrideRet ?? safeRet} {friendlyName}({invocationList})");
        foreach (var line in preCallLines)
        {
            writer.WriteLine(line);
        }

        var nativeInvocationArgs = new List<string>();

        for (var i = 0; i < marshalledParameters.Length; i++)
        {
            var tr = overload.Parameters[i];
            if (selfIndex == i)
            {
                //Some overloads seem to be generated with IntPtr as self
                //instead of the proper pointer type. TODO: investigate
                var tstr = GetTypeString(tr.Type, false);
                nativeInvocationArgs.Add($"({tstr})({selfName})");
                continue;
            }
            if (pOutIndex == i)
            {
                nativeInvocationArgs.Add("&__retval");
                continue;
            }
            var mp = marshalledParameters[i];
            if (mp == null) { continue; }
            if (mp.IsPinned)
            {
                var nativePinType = GetTypeString(tr.Type, false);
                writer.PushBlock($"fixed ({nativePinType} native_{tr.Name} = &{mp.PinTarget})");
            }

            nativeInvocationArgs.Add(mp.VarName);
        }

        var nativeInvocationStr = string.Join(", ", nativeInvocationArgs);
        var ret                 = safeRet == "void" ? string.Empty : $"{nativeRet} ret = ";

        var targetName = overload.ExportedName;
        if (targetName.Contains("nonUDT"))
        {
            targetName = targetName.Substring(0, targetName.IndexOf("_nonUDT"));
        }

        writer.WriteLine($"{ret}{classPrefix}Native.{targetName}({nativeInvocationStr});");

        foreach (var line in postCallLines)
        {
            writer.WriteLine(line);
        }

        if (safeRet != "void")
        {
            if (safeRet == "bool")
            {
                writer.WriteLine("return ret != 0;");
            }
            else if (overload.ReturnType == "char*")
            {
                writer.WriteLine("return Util.StringFromPtr(ret);");
            }
            else if (overload.ReturnType == "ImWchar*")
            {
                writer.WriteLine("return (IntPtr)ret;");
            }
            else if (overload.ReturnType == "void*")
            {
                writer.WriteLine("return (IntPtr)ret;");
            }
            else
            {
                var retVal = isWrappedType ? $"new {safeRet}(ret)" : "ret";
                writer.WriteLine($"return {retVal};");
            }
        }

        if (overrideRet != null)
            writer.WriteLine("return __retval;");
            
        for (var i = 0; i < marshalledParameters.Length; i++)
        {
            var mp = marshalledParameters[i];
            if (mp == null) { continue; }
            if (mp.IsPinned)
            {
                writer.PopBlock();
            }
        }

        writer.PopBlock();
    }

    private static string GetSafeType(string nativeRet)
    {
        switch (nativeRet)
        {
            case "bool":
                return "bool";
            case "char*":
                return "string";
            case "ImWchar*":
            case "void*":
                return "IntPtr";
            default:
                return GetTypeString(nativeRet, false);
        }
    }

    private static string GetSafeType(TypeReference typeRef)
    {
        return typeRef.Type;
    }

    private static bool GetWrappedType(string nativeType, out string wrappedType)
    {
        if (nativeType.StartsWith("Im") && nativeType.EndsWith("*") && !nativeType.StartsWith("ImVector"))
        {
            var pointerLevel = nativeType.Length - nativeType.IndexOf('*');
            if (pointerLevel > 1)
            {
                wrappedType = null;
                return false; // TODO
            }
            var nonPtrType = nativeType.Substring(0, nativeType.Length - pointerLevel);

            if (TypeInfo.WellKnownTypes.ContainsKey(nonPtrType))
            {
                wrappedType = null;
                return false;
            }

            wrappedType = nonPtrType + "Ptr";

            return true;
        }
        else
        {
            wrappedType = null;
            return false;
        }
    }

    private static bool CorrectDefaultValue(string defaultVal, TypeReference tr, out string correctedDefault)
    {
        if (tr.Type is "ImGuiContext*" or "ImPlotContext*" or "EditorContext*")
        {
            correctedDefault = "IntPtr.Zero";
            return true;
        }

        if (TypeInfo.WellKnownDefaultValues.TryGetValue(defaultVal, out correctedDefault)) { return true; }

        if (tr.Type == "bool")
        {
            correctedDefault = bool.Parse(defaultVal) ? "1" : "0";
            return true;
        }

        if (defaultVal.Contains('%')) { correctedDefault = null; return false; }

        if (tr.IsEnum)
        {
            correctedDefault = defaultVal.StartsWith("-") ? $"({tr.Type})({defaultVal})" : $"({tr.Type}){defaultVal}";
            return true;
        }

        correctedDefault = defaultVal;
        return true;
    }

    private static string GetTypeString(string typeName, bool isFunctionPointer)
    {
        var pointerLevel = 0;
        if (typeName.EndsWith("**")) { pointerLevel     = 2; }
        else if (typeName.EndsWith("*")) { pointerLevel = 1; }

        if (TypeInfo.WellKnownTypes.TryGetValue(typeName, out var typeStr))
        {
            return typeStr;
        }

        if (TypeInfo.WellKnownTypes.TryGetValue(typeName.Substring(0, typeName.Length - pointerLevel), out typeStr))
        {
            typeStr = typeStr + new string('*', pointerLevel);
        }
        else if (!TypeInfo.WellKnownTypes.TryGetValue(typeName, out typeStr))
        {
            typeStr = typeName;
            if (isFunctionPointer) { typeStr = "IntPtr"; }
        }

        return typeStr;
    }

    private static string CorrectIdentifier(string identifier)
    {
        return TypeInfo.IdentifierReplacements.TryGetValue(identifier, out var replacement) ? replacement : identifier;
    }
}