using System.Text.Json.Serialization;

namespace ImguiSharp.Generator.Data;

public class EnumValue
{

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("calc_value")]
    public int CalcValue { get; set; }

    public string Location { get; set; }
}