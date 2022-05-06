using System.Linq;

namespace CodeGenerator.Definitions;

internal class TypeReference
{
    public TypeReference(string name, string type, int asize, EnumDefinition[] enums)
        : this(name, type, asize, null, enums, null)
    {
    }

    public TypeReference(string name, string type, int asize, EnumDefinition[] enums, string[] typeVariants)
        : this(name, type, asize, null, enums, typeVariants)
    {
    }

    public TypeReference(string name, string type, int asize, string templateType, EnumDefinition[] enums)
        : this(name, type, asize, templateType, enums, null)
    {
    }

    public TypeReference(string name, string type, int asize, string templateType, EnumDefinition[] enums,
                         string[] typeVariants)
    {
        Name = name;
        Type = type.Replace("const", string.Empty).Trim();

        if (Type.StartsWith("ImVector_"))
        {
            Type = Type.EndsWith("*") ? "ImVector*" : "ImVector";
        }

        if (Type.StartsWith("ImChunkStream_"))
        {
            Type = Type.EndsWith("*") ? "ImChunkStream*" : "ImChunkStream";
        }

        TemplateType = templateType;
        ArraySize = asize;
        var startBracket = name.IndexOf('[');
        if (startBracket != -1)
        {
            //This is only for older cimgui binding jsons
            var endBracket = name.IndexOf(']');
            var sizePart = name.Substring(startBracket + 1, endBracket - startBracket - 1);
            if (ArraySize == 0)
            {
                ArraySize = ParseSizeString(sizePart, enums);
            }

            Name = Name[..startBracket];
        }

        IsFunctionPointer = Type.IndexOf('(') != -1;

        TypeVariants = typeVariants;

        IsEnum = enums.Any(t => t.Name == type || t.FriendlyName == type || TypeInfo.WellKnownEnums.Contains(type));
    }

    public string Name { get; }
    public string Type { get; }
    public string TemplateType { get; }
    public int ArraySize { get; }
    public bool IsFunctionPointer { get; }
    public string[] TypeVariants { get; }
    public bool IsEnum { get; }
    
    private static string? GetWrappedType(string nativeType)
    {
        if (nativeType.StartsWith("Im") && nativeType.EndsWith("*") && !nativeType.StartsWith("ImVector"))
        {
            var pointerLevel = nativeType.Length - nativeType.IndexOf('*');
            if (pointerLevel > 1)
            {
                return null; // TODO
            }

            var nonPtrType = nativeType.Substring(0, nativeType.Length - pointerLevel);

            if (TypeInfo.WellKnownTypes.ContainsKey(nonPtrType))
            {
                return null;
            }

            return nonPtrType + "Ptr";
        }

        return null;
    }

    private int ParseSizeString(string sizePart, EnumDefinition[] enums)
    {
        var plusStart = sizePart.IndexOf('+');
        if (plusStart != -1)
        {
            var first = sizePart[..plusStart];
            var second = sizePart.Substring(plusStart, sizePart.Length - plusStart);
            var firstVal = int.Parse(first);
            var secondVal = int.Parse(second);
            return firstVal + secondVal;
        }

        if (int.TryParse(sizePart, out var ret))
        {
            return ret;
        }

        foreach (var ed in enums)
        {
            if (!sizePart.StartsWith(ed.Name))
            {
                continue;
            }

            foreach (var member in ed.Members)
                if (member.Name == sizePart)
                {
                    return int.Parse(member.Value);
                }
        }

        ret = -1;

        return ret;
    }

    public TypeReference WithVariant(int variantIndex, EnumDefinition[] enums)
    {
        return variantIndex == 0
                   ? this
                   : new TypeReference(Name, TypeVariants[variantIndex - 1], ArraySize, TemplateType, enums);
    }
}