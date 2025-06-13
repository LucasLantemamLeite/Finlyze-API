namespace Finlyze.Domain.ValueObject.UserAccountObjects;

public class NameObject : ValueObject
{
    public string Value { get; }

    public NameObject(string name)
    {
        Value = name;
    }
}