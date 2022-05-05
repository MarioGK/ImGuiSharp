using System.Text.Json.Serialization;

namespace ImGuiSharp.Generator.Data;

public class BaseDefinition
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}