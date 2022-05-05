namespace CodeGenerator.Definitions;

internal class EnumMemberDefinition
{
    public EnumMemberDefinition(string name, string value)
    {
        Name = name;
        Value = value;
    }

    public string Name { get; set; }
    public string Value { get; set; }
}