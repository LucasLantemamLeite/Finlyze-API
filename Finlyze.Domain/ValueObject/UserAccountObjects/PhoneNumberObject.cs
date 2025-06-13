namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class PhoneNumber : ValueObject
{
    public string Value { get; set; }

    public PhoneNumber(string phone_number)
    {
        Value = phone_number;
    }
}