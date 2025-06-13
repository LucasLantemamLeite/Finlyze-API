namespace Finlyze.Domain.ValueObject.UserAccountObjects;

public class Password
{
    public string Value { get; set; }

    public Password(string password)
    {
        Value = password;
    }
}
