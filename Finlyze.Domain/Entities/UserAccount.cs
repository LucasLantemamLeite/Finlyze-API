using Finlyze.Domain.ValueObject.UserAccountObject;

namespace Finlyze.Domain.Entity;

public class UserAccount : Entity
{
    public Name Name { get; private set; }
    public Login Login { get; private set; }
    public Email Email { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }
    public BirthDate BirthDate { get; private set; }
    public CreateAt CreateAt { get; private set; }
    public Active Active { get; private set; }
    public Role Role { get; private set; }

    public UserAccount(string name, string login, string email, string phone_number, DateTime birth_date)
    {
        Name = new Name(name);
        Login = new Login(login);
        Email = new Email(email);
        PhoneNumber = new PhoneNumber(phone_number);
        BirthDate = new BirthDate(birth_date);
        CreateAt = new CreateAt();
        Active = new Active();
        Role = new Role();
    }
}