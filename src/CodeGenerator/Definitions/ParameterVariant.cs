﻿namespace CodeGenerator.Definitions;

internal class ParameterVariant
{
    public string Name { get; }

    public string OriginalType { get; }

    public string[] VariantTypes { get; }

    public bool Used { get; set; }

    public ParameterVariant(string name, string originalType, string[] variantTypes)
    {
        Name         = name;
        OriginalType = originalType;
        VariantTypes = variantTypes;
        Used         = false;
    }
}