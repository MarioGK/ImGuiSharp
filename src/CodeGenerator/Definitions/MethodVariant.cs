namespace CodeGenerator.Definitions;

internal class MethodVariant
{
    public string Name { get; }

    public ParameterVariant[] Parameters { get; }

    public MethodVariant(string name, ParameterVariant[] parameters)
    {
        Name       = name;
        Parameters = parameters;
    }
}