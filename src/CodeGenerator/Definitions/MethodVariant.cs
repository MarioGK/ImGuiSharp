namespace CodeGenerator.Definitions;

internal class MethodVariant
{
    public MethodVariant(string name, ParameterVariant[] parameters)
    {
        Name = name;
        Parameters = parameters;
    }

    public string Name { get; }

    public ParameterVariant[] Parameters { get; }
}