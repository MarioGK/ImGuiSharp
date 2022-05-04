using System.Collections.Generic;
using System.IO;
using System.Linq;
using CodeGenerator.Definitions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CodeGenerator;

internal class DefinitionsParser
{
    public EnumDefinition[] Enums;
    public HashSet<string> ExcludedStructs = new() {"FindBestWindowPosForPopupEx"};
    public FunctionDefinition[] Functions;
    public TypeDefinition[] Types;
    public Dictionary<string, MethodVariant> Variants;

    private static int GetInt(JToken token, string key)
    {
        var v = token[key];
        return v?.ToObject<int>() ?? 0;
    }

    private void ParseVariants(string directory)
    {
        JObject variantsJson = null;
        if (File.Exists(Path.Combine(directory, "variants.json")))
        {
            using var fs = File.OpenText(Path.Combine(directory, "variants.json"));
            using var jr = new JsonTextReader(fs);
            variantsJson = JObject.Load(jr);
        }

        Variants = new Dictionary<string, MethodVariant>();

        if (variantsJson == null)
        {
            return;
        }

        foreach (var jt in variantsJson.Children())
        {
            var jp = (JProperty) jt;
            var methodVariants = jp.Values().Select(jv =>
            {
                return new ParameterVariant(jv["name"]?.ToString(),
                                            jv["type"]?.ToString(),
                                            jv["variants"]?.Select(s => s.ToString()).ToArray());
            }).ToArray();
            Variants.Add(jp.Name, new MethodVariant(jp.Name, methodVariants));
        }
    }

    private void ParseTypes(string directory)
    {
        JObject typesJson;
        using (var fs = File.OpenText(Path.Combine(directory, "structs_and_enums.json")))
        using (var jr = new JsonTextReader(fs))
        {
            typesJson = JObject.Load(jr);
        }

        var typeLocations = typesJson["locations"];

        Enums = typesJson["enums"].Select(jt =>
        {
            var jp = (JProperty) jt;
            var name = jp.Name;
            /*if (typeLocations?[jp.Name]?.Value<string>().Contains("internal") ?? false) {
                return null;
            }*/

            if (jp.Name.EndsWith("Private_"))
            {
                return null;
            }

            var elements = jp.Values()
                             .Select(v => new EnumMemberDefinition(v["name"].ToString(), v["calc_value"].ToString()))
                             .ToArray();
            return new EnumDefinition(name, elements);
        }).Where(x => x != null).ToArray();

        Types = typesJson["structs"].Select(jt =>
        {
            var jp = (JProperty) jt;
            var name = jp.Name;
            /*if (typeLocations?[jp.Name]?.Value<string>().Contains("internal") ?? false) {
                return null;
            }*/

            if (ExcludedStructs.Contains(name))
            {
                return null;
            }

            var fields = jp.Values().Select(v =>
            {
                if (v["type"]!.ToString().Contains("static"))
                {
                    return null;
                }


                return new TypeReference(
                                         v["name"]?.ToString(),
                                         v["type"].ToString(),
                                         GetInt(v, "size"),
                                         v["template_type"]?.ToString(),
                                         Enums);
            }).Where(tr => tr != null).ToArray();
            return new TypeDefinition(name, fields);
        }).Where(x => x != null).ToArray();
    }

    private void ParseFunctions(string directory)
    {
        JObject functionsJson;
        using (var fs = File.OpenText(Path.Combine(directory, "definitions.json")))
        using (var jr = new JsonTextReader(fs))
        {
            functionsJson = JObject.Load(jr);
        }

        Functions = functionsJson.Children().Select(jt =>
        {
            var jp = (JProperty) jt;
            var name = jp.Name;
            var hasNonUdtVariants =
                jp.Values().Any(val => val["ov_cimguiname"]?.ToString().EndsWith("nonUDT") ?? false);
            var overloads = jp.Values().Select(val =>
            {
                var ovCimguiname = val["ov_cimguiname"]?.ToString();
                var cimguiname = val["cimguiname"]?.ToString();
                var friendlyName = val["funcname"]?.ToString();
                if (cimguiname!.EndsWith("_destroy"))
                {
                    friendlyName = "Destroy";
                }

                //skip internal functions
                var typename = val["stname"]?.ToString();
                if (!string.IsNullOrEmpty(typename))
                {
                    if (!Types.Any(x => x.Name == val["stname"]?.ToString()))
                    {
                        return null;
                    }
                }

                if (friendlyName == null)
                {
                    return null;
                }

                if (val["location"]?.ToString() == "internal")
                {
                    return null;
                }
                /*if (val["location"]?.ToString().Contains("internal") ?? false)
                {
                    return null;
                }*/

                var exportedName = ovCimguiname ?? cimguiname;

                if (hasNonUdtVariants && !exportedName.EndsWith("nonUDT2"))
                {
                    return null;
                }

                string selfTypeName = null;
                var underscoreIndex = exportedName.IndexOf('_');
                if (underscoreIndex > 0 &&
                    !exportedName.StartsWith("ig")) // Hack to exclude some weirdly-named non-instance functions.
                {
                    selfTypeName = exportedName[..underscoreIndex];
                }

                var parameters = new List<TypeReference>();

                // find any variants that can be applied to the parameters of this method based on the method name
                Variants.TryGetValue(jp.Name, out var methodVariants);

                foreach (var p in val["argsT"]!)
                {
                    var pType = p["type"]?.ToString();
                    var pName = p["name"]?.ToString();

                    // if there are possible variants for this method then try to match them based on the parameter name and expected type
                    var matchingVariant =
                        methodVariants?.Parameters?.FirstOrDefault(pv => pv.Name         == pName &&
                                                                         pv.OriginalType == pType) ?? null;
                    if (matchingVariant != null)
                    {
                        matchingVariant.Used = true;
                    }

                    parameters.Add(new TypeReference(pName, pType, 0, Enums, matchingVariant?.VariantTypes));
                }

                var defaultValues = val["defaults"].Cast<JProperty>()
                                                   .ToDictionary(dvProp => dvProp.Name,
                                                                 dvProp => dvProp.Value.ToString());
                var returnType = val["ret"]?.ToString() ?? "void";
                string comment = null;

                var structName = val["stname"].ToString();
                var isConstructor = val.Value<bool>("constructor");
                var isDestructor = val.Value<bool>("destructor");
                if (isConstructor)
                {
                    returnType = structName + "*";
                }

                return new OverloadDefinition(
                                              exportedName,
                                              friendlyName,
                                              parameters.ToArray(),
                                              defaultValues,
                                              returnType,
                                              structName,
                                              comment,
                                              isConstructor,
                                              isDestructor);
            }).Where(od => od != null).ToArray();
            return overloads.Length == 0 ? null : new FunctionDefinition(name, overloads, Enums);
        }).Where(x => x != null).OrderBy(fd => fd.Name).ToArray();
    }

    public void LoadFrom(string directory)
    {
        ParseVariants(directory);
        ParseTypes(directory);
        ParseFunctions(directory);
    }
}