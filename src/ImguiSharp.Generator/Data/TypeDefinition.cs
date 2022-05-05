using System.Text.Json.Serialization;
using ImGuiSharp.Generator.Helpers;

namespace ImGuiSharp.Generator.Data;

internal class TypeDefinition : BaseDefinition
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    public new string FriendlyName => GetFriendlyName();

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("template_type")]
    public string? TemplateType { get; set; }

    [JsonPropertyName("size")]
    public int? ArraySize { get; set; }

    [JsonIgnore]
    public string[] TypeVariants { get; }

    [JsonIgnore]
    public bool IsEnum { get; set; }
    
    [JsonIgnore]
    public bool IsArray => ArraySize is > 0;
    
    public bool IsLegalType => TypeInfo.LegalFixedTypes.Contains(Type);

    [JsonIgnore]
    public string TypeName => Type.GetTypeString(IsFunctionPointer);

    //TODO move this to struct.template file
    public string AddressTarget => IsLegalType ? $"NativePtr->{FriendlyName}" : $"&NativePtr->{FriendlyName}0";

    public bool IsFunctionPointer => Type.IndexOf('(') != -1;

    private string GetFriendlyName()
    {
        var words = Name.Split('_').Where(x => !string.IsNullOrEmpty(x)).ToArray();
        for (var i = 0; i < words.Length; i++) words[i] = words[i][..1].ToUpper() + words[i][1..];

        return string.Join("", words);
    }

    public void CleanType()
    {
        Type = Type.Replace("const", string.Empty).Trim();

        foreach (var prefix in TypeInfo.PrefixToRemove)
        {
            if (!Type.StartsWith(prefix))
            {
                continue;
            }

            var cleanPrefix = prefix.Replace("_", "");
            Type = Type.EndsWith("*") ? $"{cleanPrefix}*" : cleanPrefix;
        }
    }
}