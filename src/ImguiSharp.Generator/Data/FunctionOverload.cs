using System.Text.Json.Serialization;

namespace ImGuiSharp.Generator.Data;

internal class FunctionOverload
{
    public string Id { get; set; }

    [JsonPropertyName("args")]
    public string RawArguments { get; set; }

    [JsonPropertyName("argsT")]
    public List<ArgumentDefinition> ArgumentDefinitions { get; set; }

    [JsonPropertyName("argsoriginal")]
    public string RawArgumentsOriginal { get; set; }

    [JsonPropertyName("call_args")]
    public string CallArguments { get; set; }

    [JsonPropertyName("cimguiname")]
    public string Cimguiname { get; set; }

    //[JsonPropertyName("defaults")]
    //public Defaults Defaults { get; set; }

    [JsonPropertyName("funcname")]
    public string FunctionName { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("ov_cimguiname")]
    public string? CimguiName { get; set; }

    [JsonPropertyName("ret")]
    public string ReturnType { get; set; }

    [JsonPropertyName("signature")]
    public string Signature { get; set; }

    [JsonPropertyName("stname")]
    public string StName { get; set; }

    [JsonPropertyName("templated")]
    public bool Templated { get; set; }
    
    public string ExportedName => GetExportedName();

    public string GetExportedName()
    {
        var exportedName = CimguiName ?? Cimguiname;
        if (exportedName.StartsWith("ig"))
        {
            exportedName = exportedName.Substring(2, exportedName.Length - 2);
        }
        return exportedName;
    }

    public void FixReturnType()
    {
        ReturnType = ReturnType.Replace("const", string.Empty).Replace("inline", string.Empty).Trim();
    }
}