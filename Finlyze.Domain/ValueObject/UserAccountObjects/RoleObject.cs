using Finlyze.Domain.ValueObject.Enumerator;
using Finlyze.Domain.ValueObject.Validation;

namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class Role : ValueObject
{
    public ERole Value { get; set; }

    public Role(int role = 1)
    {
        ERoleException.ThrowIfNotIsDefined(role, "Role inválido.");
        Value = (ERole)role;
    }

    private Role() { }
}