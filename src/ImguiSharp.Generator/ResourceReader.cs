using System.Reflection;

namespace ImGuiSharp.Generator;

internal class ResourceReader
{
    public static string? GetResource(string endWith, Type? assemblyType = null)
    {
        var assembly = GetAssembly(assemblyType);

        var resourceNames = assembly?.GetManifestResourceNames();

        //throw new InvalidOperationException(string.Join(',', resourceNames));

        var resources = resourceNames?.Where(r => r.EndsWith(endWith)).ToList();

        if (resources == null || !resources.Any())
        {
            throw new InvalidOperationException($"There is no resources that ends with '{endWith}'");
        }

        if (resources.Count > 1)
        {
            throw new InvalidOperationException($"There is more then one resource that ends with '{endWith}'");
        }

        var resourceName = resources.Single();

        return ReadEmbeddedResource(assembly, resourceName);
    }

    private static Assembly? GetAssembly(Type? assemblyType)
    {
        var assembly = assemblyType == null ? Assembly.GetExecutingAssembly() : Assembly.GetAssembly(assemblyType);

        return assembly;
    }

    private static string? ReadEmbeddedResource(Assembly? assembly, string name)
    {
        using var resourceStream = assembly?.GetManifestResourceStream(name);
        if (resourceStream == null)
        {
            return null;
        }

        using var streamReader = new StreamReader(resourceStream);
        return streamReader.ReadToEnd();
    }
}