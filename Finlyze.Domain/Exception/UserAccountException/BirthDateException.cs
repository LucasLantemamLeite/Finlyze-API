namespace Finlyze.Domain.ValueObject.Validation;

public class BirthDateException : Exception
{
    private BirthDateException(string message) : base(message) { }

    public static void ThrowIfInvalid(DateTime birth_date, string message_future, string message_age)
    {
        if (birth_date > DateTime.Today)
            throw new BirthDateException(message_future);

        if (birth_date.AddYears(18) > DateTime.Today)
            throw new BirthDateException(message_age);
    }
}