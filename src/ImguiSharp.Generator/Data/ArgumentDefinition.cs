using System.Text.Json.Serialization;

namespace ImGuiSharp.Generator.Data;

public class ArgumentDefinition
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}