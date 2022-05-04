namespace CodeGenerator.Definitions;

internal class TypeDefinition
{
    public TypeDefinition(string name, TypeReference[] fields)
    {
        Name = name;
        Fields = fields;
    }

    public string Name { get; }
    public TypeReference[] Fields { get; }
}