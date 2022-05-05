using System.Text.Json.Serialization;

namespace ImGuiSharp.Generator.Data;

internal class ArgumentDefinition : BaseDefinition
{
    

    [JsonPropertyName("type")]
    public string Type { get; set; }
}