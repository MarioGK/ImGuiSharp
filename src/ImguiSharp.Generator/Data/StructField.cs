using System.Text.Json.Serialization;

namespace ImguiSharp.Generator.Data;

public class StructField
{
    [JsonPropertyName("name")]
    public string  Name         { get; set; }
    [JsonPropertyName("type")]
    public string  Type         { get; set; }
    [JsonPropertyName("template_type")]
    public string? TemplateType { get; set; }
    [JsonPropertyName("size")]
    public int?     ArraySize    { get; set; }

}