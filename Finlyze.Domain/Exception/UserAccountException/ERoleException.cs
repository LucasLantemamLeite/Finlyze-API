using Finlyze.Domain.ValueObject.Enumerator;

namespace Finlyze.Domain.ValueObject.Validation;

public class ERoleException : Exception
{
    private ERoleException(string message) : base(message) { }

    public static void ThrowIfNotIsDefined(int role, string message)
    {
        if (!Enum.IsDefined(typeof(ERole), role))
            throw new ERoleException(message);
    }
}