namespace CodeGenerator.Definitions;

internal class TypeDefinition
{
    public string          Name   { get; }
    public TypeReference[] Fields { get; }

    public TypeDefinition(string name, TypeReference[] fields)
    {
        Name   = name;
        Fields = fields;
    }
}