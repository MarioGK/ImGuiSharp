using System.Text.Json.Serialization;

namespace ImguiSharp.Generator.Data;

public class FunctionDefinition
{
    public string  Id { get; set; }
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
    public string CimguiName { get; set; }

    [JsonPropertyName("ret")]
    public string ReturnType { get; set; }

    [JsonPropertyName("signature")]
    public string Signature { get; set; }

    [JsonPropertyName("stname")]
    public string StName { get; set; }

    [JsonPropertyName("templated")]
    public bool Templated { get; set; }
}