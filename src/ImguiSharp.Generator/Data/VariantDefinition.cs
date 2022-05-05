using System.Text.Json.Serialization;

namespace ImGuiSharp.Generator.Data;

public class VariantDefinition : BaseDefinition
{
    [JsonPropertyName("variants")]
    public List<string?> Variants { get; set; } = new();

    public string Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}