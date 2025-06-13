namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class BirthDate : ValueObject
{
    public DateTime Value { get; set; }

    public BirthDate(DateTime birth_date)
    {
        Value = birth_date;
    }
}