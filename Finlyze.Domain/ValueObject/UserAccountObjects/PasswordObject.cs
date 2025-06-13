using Finlyze.Domain.ValueObject.Validation;

namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class Password
{
    public string Value { get; set; }

    public Password(string password)
    {
        DomainException.ThrowIfFalse(!string.IsNullOrWhiteSpace(password), "Password não pode ser nulo ou vazio.");
        Value = password;
    }
}
