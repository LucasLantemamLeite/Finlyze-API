namespace Finlyze.Domain.ValueObject.UserAccountObjects;

public class Email
{
    public string Value { get; set; }

    public Email(string email)
    {
        Value = email;
    }
}