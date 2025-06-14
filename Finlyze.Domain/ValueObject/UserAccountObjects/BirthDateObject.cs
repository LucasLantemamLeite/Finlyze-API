using Finlyze.Domain.ValueObject.Validation;

namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class BirthDate : ValueObject
{
    public DateTime Value { get; set; }

    public BirthDate(DateTime birth_date)
    {
        BirthDateException.ThrowIfInvalid(birth_date, "BirthDate não pode ser uma data futura.", "Usuário não pode ser menor de idade.");
        Value = birth_date;
    }

    private BirthDate() { }
}