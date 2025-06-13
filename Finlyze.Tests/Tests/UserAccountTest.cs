using Finlyze.Domain.ValueObject.UserAccountObject;
using Finlyze.Domain.ValueObject.Validation;

namespace Finlyze.Test.Validation.UserAccount;

[Trait("Category", "UserAccount")]
public class UserAccountTest
{

    [Theory]
    [InlineData("Lucas")]
    [InlineData("Ana")]
    [InlineData("Maria")]
    [InlineData("LUCAS")]
    public static void Dado_Um_Name_Válido_Adiciona_Na_Entidade(string name)
    {
        var ex = Record.Exception(() => new Name(name));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData("")]
    [InlineData("     ")]
    [InlineData(null)]
    public static void Dado_Um_Name_Vazio_Ou_Nulo_Lança_Exceção(string name)
    {
        var ex = Assert.Throws<DomainException>(() => new Name(name));
        Assert.NotNull(ex);
        Assert.Equal("Name não pode ser nulo ou vazio.", ex.Message);
    }


    [Theory]
    [InlineData("lucas")]
    [InlineData("Lucas")]
    [InlineData("LUCAS")]
    public static void Dado_Um_Login_Válido_Adiciona_Na_Entidade(string login)
    {
        var ex = Record.Exception(() => new Login(login));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData("")]
    [InlineData("     ")]
    [InlineData(null)]
    public static void Dado_Um_Login_Vazio_Ou_Nulo_Lança_Exceção(string login)
    {
        var ex = Assert.Throws<DomainException>(() => new Login(login));
        Assert.NotNull(ex);
        Assert.Equal("Login não pode ser nulo ou vazio.", ex.Message);
    }


    [Theory]
    [InlineData("senha")]
    [InlineData("Senha")]
    [InlineData("Senha1234")]
    public static void Dado_Um_Password_Válido_Adiciona_Na_Entidade(string password)
    {
        var ex = Record.Exception(() => new Password(password));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData("")]
    [InlineData("     ")]
    [InlineData(null)]
    public static void Dado_Um_Password_Vazio_Ou_Nulo_Lança_Exceção(string password)
    {
        var ex = Assert.Throws<DomainException>(() => new Password(password));
        Assert.NotNull(ex);
        Assert.Equal("Password não pode ser nulo ou vazio.", ex.Message);
    }

    [Theory]
    [InlineData("teste@gmail.com")]
    [InlineData("teste@gmail.com.br")]
    [InlineData("TESTE@GMAIL.COM")]
    [InlineData("TESTE@GMAIL.COM.BR")]
    [InlineData("teste-_.+123@gmail.com.br")]
    [InlineData("TESTE1234@GMAIL.COM")]
    [InlineData("TESTE1234@GMAIL.COM.BR")]
    public static void Dado_Um_Email_Válido_Adiciona_Na_Entidade(string email)
    {
        var ex = Record.Exception(() => new Email(email));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData("@gmail.com")]
    [InlineData("@gmail.com.br")]
    [InlineData("@GMAIL.COM.BR")]
    public static void Dado_Um_Email_Sem_Local_Part_Lança_Exceção(string email)
    {
        var ex = Assert.Throws<EmailRegexException>(() => new Email(email));
        Assert.NotNull(ex);
        Assert.Equal("Email inválido.", ex.Message);
    }

    [Theory]
    [InlineData("teste")]
    [InlineData("teste1234")]
    [InlineData("TESTE")]
    public static void Dado_Um_Email_Sem_Domínio_Lança_Exceção(string email)
    {
        var ex = Assert.Throws<EmailRegexException>(() => new Email(email));
        Assert.NotNull(ex);
        Assert.Equal("Email inválido.", ex.Message);
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData("       ")]
    public static void Dado_Um_Email_Vazio_Lança_Exceção(string email)
    {
        var ex = Assert.Throws<EmailRegexException>(() => new Email(email));
        Assert.NotNull(ex);
        Assert.Equal("Email inválido.", ex.Message);
    }

    [Theory]
    [InlineData("+5595997534241")]
    [InlineData("+5567982817661")]
    [InlineData("+5594985171065")]
    public static void Dado_Um_PhoneNumber_Válido_Adiciona_Na_Entidade(string phone_number)
    {
        var ex = Record.Exception(() => new PhoneNumber(phone_number));
        Assert.Null(ex);
    }


    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData("       ")]
    public static void Dado_Um_PhoneNumber_Vazio_Lança_Exceção(string phone_number)
    {
        var ex = Assert.Throws<PhoneNumberRegexException>(() => new PhoneNumber(phone_number));
        Assert.NotNull(ex);
        Assert.Equal("PhoneNumber inválido.", ex.Message);
    }

    [Theory]
    [InlineData("+")]

    public static void Dado_Um_PhoneNumber_Sem_Dígitos_Lança_Exceção(string phone_number)
    {
        var ex = Assert.Throws<PhoneNumberRegexException>(() => new PhoneNumber(phone_number));
        Assert.NotNull(ex);
        Assert.Equal("PhoneNumber inválido.", ex.Message);
    }


    [Theory]
    [InlineData("+5595997")]
    [InlineData("+556798")]
    [InlineData("+55949")]

    public static void Dado_Um_PhoneNumber_Com_Menos_De_8_Dígitos_Lança_Exceção(string phone_number)
    {
        var ex = Assert.Throws<PhoneNumberRegexException>(() => new PhoneNumber(phone_number));
        Assert.NotNull(ex);
        Assert.Equal("PhoneNumber inválido.", ex.Message);
    }

    [Theory]
    [InlineData("+5595997534241456")]
    [InlineData("+556798281766145672")]
    [InlineData("+5594985171065897134")]

    public static void Dado_Um_PhoneNumber_Com_Mais_De_15_Dígitos_Lança_Exceção(string phone_number)
    {
        var ex = Assert.Throws<PhoneNumberRegexException>(() => new PhoneNumber(phone_number));
        Assert.NotNull(ex);
        Assert.Equal("PhoneNumber inválido.", ex.Message);
    }

    [Theory]
    [InlineData("5595997534241")]
    [InlineData("5567982817661")]
    [InlineData("5594985171065")]
    public static void Dado_Um_PhoneNumber_Sem_Sinal_De_Mais_Lança_Exceção(string phone_number)
    {
        var ex = Assert.Throws<PhoneNumberRegexException>(() => new PhoneNumber(phone_number));
        Assert.NotNull(ex);
        Assert.Equal("PhoneNumber inválido.", ex.Message);
    }

    [Theory]
    [InlineData(2000, 01, 01)]
    [InlineData(1990, 05, 31)]
    [InlineData(1980, 06, 17)]
    public static void Dado_Um_BirthDate_Válido_Adiciona_Na_Entidade(int ano, int mes, int dia)
    {
        var date = new DateTime(ano, mes, dia);
        var ex = Record.Exception(() => new BirthDate(date));
        Assert.Null(ex);
    }

    [Fact]
    public static void Dado_Um_BirthDate_Com_Data_Futura_Lança_Exceção()
    {
        var date = DateTime.Now.AddSeconds(1);
        var ex = Assert.Throws<BirthDateException>(() => new BirthDate(date));
        Assert.NotNull(ex);
        Assert.Equal("BirthDate não pode ser uma data futura.", ex.Message);
    }

    [Fact]
    public static void Dado_Um_BirthDate_Menor_De_Idade_Lança_Exceção()
    {
        var date = DateTime.Now.AddYears(-17);
        var ex = Assert.Throws<BirthDateException>(() => new BirthDate(date));
        Assert.NotNull(ex);
        Assert.Equal("Usuário não pode ser menor de idade.", ex.Message);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public static void Dado_Um_Role_Válido_Adiciona_Na_Entidade(int role)
    {
        var ex = Record.Exception(() => new Role(role));
        Assert.Null(ex);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(999)]
    [InlineData(-1)]
    public static void Dado_Um_Role_Inválido_Adiciona_Na_Entidade(int role)
    {
        var ex = Assert.Throws<ERoleException>(() => new Role(role));
        Assert.NotNull(ex);
        Assert.Equal("Role inválido.", ex.Message);
    }
}