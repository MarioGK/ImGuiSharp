using System.Text.Json.Serialization;

namespace ImGuiSharp.Generator.Data;

public class ArgumentDefinition : BaseDefinition
{
    

    [JsonPropertyName("type")]
    public string Type { get; set; }
}