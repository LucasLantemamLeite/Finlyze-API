using System.Text.RegularExpressions;

namespace Finlyze.Domain.ValueObject.Validation;

public partial class EmailRegexException : Exception
{
    private EmailRegexException(string message) : base(message) { }

    [GeneratedRegex(@"^$", RegexOptions.IgnoreCase)]
    private static partial Regex EmailRegex();

    public static void ThrowIfNotMatch(string email, string message)
    {
        if (!EmailRegex().IsMatch(email))
            throw new EmailRegexException(message);
    }
}