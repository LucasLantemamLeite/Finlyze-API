namespace Finlyze.Domain.ValueObject;

public class CreateAt : ValueObject
{
    public DateTime Value { get; set; }
    public CreateAt()
    {
        Value = DateTime.UtcNow;
    }
}