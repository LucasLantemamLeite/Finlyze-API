namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class Email
{
    public string Value { get; set; }

    public Email(string email)
    {
        Value = email;
    }
}