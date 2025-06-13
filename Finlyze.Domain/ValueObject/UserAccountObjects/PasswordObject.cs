namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class Password
{
    public string Value { get; set; }

    public Password(string password)
    {
        Value = password;
    }
}
