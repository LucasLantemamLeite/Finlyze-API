namespace Finlyze.Domain.ValueObject;

public class Active : ValueObject
{
    public bool Value { get; set; }

    public Active(bool active = true)
    {
        Value = active;
    }
}