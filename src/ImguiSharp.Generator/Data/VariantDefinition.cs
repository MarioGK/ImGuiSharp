using System.Text.Json.Serialization;

namespace ImguiSharp.Generator.Data;

public class VariantDefinition
{
    [JsonPropertyName("variants")]
    public List<string?> Variants { get; set; } = new();
    public string        Id       { get; set; }
    [JsonPropertyName("name")]
    public string        Name     { get; set; }
    [JsonPropertyName("type")]
    public string        Type     { get; set; }
    
}