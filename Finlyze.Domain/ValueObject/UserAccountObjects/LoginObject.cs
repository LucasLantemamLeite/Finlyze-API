using Finlyze.Domain.ValueObject.Validation;

namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class Login : ValueObject
{
    public string Value { get; }

    public Login(string login)
    {
        DomainException.ThrowIfFalse(!string.IsNullOrWhiteSpace(login), "Login não pode ser nulo ou vazio.");
        Value = login;
    }
}