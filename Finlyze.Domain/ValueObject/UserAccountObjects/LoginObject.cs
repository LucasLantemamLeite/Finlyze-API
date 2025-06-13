namespace Finlyze.Domain.ValueObject;

public class LoginObject : ValueObject
{
    public string Value { get; }

    public LoginObject(string login)
    {
        Value = login;
    }
}