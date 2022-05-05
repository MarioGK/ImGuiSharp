using System.Text.Json.Serialization;

namespace ImGuiSharp.Generator.Data;

internal class EnumValue : BaseDefinition
{
    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("calc_value")]
    public int CalcValue { get; set; }

    public string Location { get; set; }
}