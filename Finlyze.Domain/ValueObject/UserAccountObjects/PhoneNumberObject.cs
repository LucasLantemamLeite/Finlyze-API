using Finlyze.Domain.ValueObject.Validation;

namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class PhoneNumber : ValueObject
{
    public string Value { get; set; }

    public PhoneNumber(string phone_number)
    {
        PhoneNumberRegexException.ThrowIfNotMatch(phone_number, "PhoneNumber inválido.");
        Value = phone_number;
    }

    private PhoneNumber() { }
}