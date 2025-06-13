namespace Finlyze.Domain.ValueObject;

public class BirthDate : ValueObject
{
    public DateTime Value { get; set; }

    public BirthDate(DateTime birth_date)
    {
        Value = birth_date;
    }
}