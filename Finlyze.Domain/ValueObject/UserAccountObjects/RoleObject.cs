using Finlyze.Domain.ValueObject.Enumerator;

namespace Finlyze.Domain.ValueObject;

public class Role : ValueObject
{
    public ERole Value { get; set; }

    public Role(int role = 1)
    {
        Value = (ERole)role;
    }
}