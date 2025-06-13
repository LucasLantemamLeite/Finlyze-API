namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class Name : ValueObject
{
    public string Value { get; }

    public Name(string name)
    {
        Value = name;
    }
}