using System.Collections.Generic;

namespace CodeGenerator.Definitions;

internal class FunctionDefinition
{
    public string               Name      { get; }
    public OverloadDefinition[] Overloads { get; }

    public FunctionDefinition(string name, OverloadDefinition[] overloads, EnumDefinition[] enums)
    {
        Name      = name;
        Overloads = ExpandOverloadVariants(overloads, enums);
    }

    private OverloadDefinition[] ExpandOverloadVariants(OverloadDefinition[] overloads, EnumDefinition[] enums)
    {
        var newDefinitions = new List<OverloadDefinition>();

        foreach (var overload in overloads)
        {
            var hasVariants   = false;
            var variantCounts = new int[overload.Parameters.Length];

            for (var i = 0; i < overload.Parameters.Length; i++)
            {
                if (overload.Parameters[i].TypeVariants != null)
                {
                    hasVariants      = true;
                    variantCounts[i] = overload.Parameters[i].TypeVariants.Length + 1;
                }
                else
                {
                    variantCounts[i] = 1;
                }
            }

            if (hasVariants)
            {
                var totalVariants                                            = variantCounts[0];
                for (var i = 1; i < variantCounts.Length; i++) totalVariants *= variantCounts[i];

                for (var i = 0; i < totalVariants; i++)
                {
                    var parameters = new TypeReference[overload.Parameters.Length];
                    var div        = 1;

                    for (var j = 0; j < parameters.Length; j++)
                    {
                        var k = (i / div) % variantCounts[j];

                        parameters[j] = overload.Parameters[j].WithVariant(k, enums);

                        if (j > 0) div *= variantCounts[j];
                    }

                    newDefinitions.Add(overload.WithParameters(parameters));
                }
            }
            else
            {
                newDefinitions.Add(overload);
            }
        }

        return newDefinitions.ToArray();
    }
}