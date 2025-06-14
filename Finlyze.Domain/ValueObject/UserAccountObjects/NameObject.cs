using Finlyze.Domain.ValueObject.Validation;

namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class Name : ValueObject
{
    public string Value { get; }

    public Name(string name)
    {
        DomainException.ThrowIfFalse(!string.IsNullOrWhiteSpace(name), "Name não pode ser nulo ou vazio.");
        Value = name;
    }

    private Name() { }
}