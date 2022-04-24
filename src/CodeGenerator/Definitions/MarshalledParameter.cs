namespace CodeGenerator.Definitions;

internal class MarshalledParameter
{
    public MarshalledParameter(string marshalledType, bool isPinned, string varName, bool hasDefaultValue)
    {
        MarshalledType  = marshalledType;
        IsPinned        = isPinned;
        VarName         = varName;
        HasDefaultValue = hasDefaultValue;
    }

    public string MarshalledType  { get; }
    public bool   IsPinned        { get; }
    public string VarName         { get; }
    public bool   HasDefaultValue { get; }
    public string PinTarget       { get; internal set; }
}