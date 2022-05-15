using System.Text.Json.Serialization;

namespace ImGuiSharp.Generator.Data;

internal class BaseDefinition
{
    [JsonIgnore]
    public string Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    public string FriendlyName => Name.EndsWith("_") ? Name[..^1] : Name;
}