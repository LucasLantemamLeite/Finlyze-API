namespace Finlyze.Domain.ValueObject.UserAccountObject;

public class Active : ValueObject
{
    public bool Value { get; set; }

    public Active(bool active = true)
    {
        Value = active;
    }

    private Active() { }
}