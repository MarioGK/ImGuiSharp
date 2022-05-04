namespace CodeGenerator.Definitions;

internal class EnumMemberDefinition
{
    public EnumMemberDefinition(string name, string value)
    {
        Name = name;
        Value = value;
    }

    public string Name { get; }
    public string Value { get; }
}