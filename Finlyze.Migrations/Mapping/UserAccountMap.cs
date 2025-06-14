using Finlyze.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Finlyze.Migrations.Data.Mapping;

public class UserAccountMap : IEntityTypeConfiguration<UserAccount>
{
    public void Configure(EntityTypeBuilder<UserAccount> builder)
    {
        builder.ToTable("UserAccount");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
        .HasColumnName("Id")
        .ValueGeneratedOnAdd();

        builder.OwnsOne(x => x.Name, name =>
        {
            name.Property(x => x.Value)
            .HasColumnName("Name")
            .HasColumnType("Nvarchar(100)")
            .IsRequired();
        });

        builder.OwnsOne(x => x.Login, login =>
        {
            login.Property(x => x.Value)
            .HasColumnName("Login")
            .HasColumnType("Nvarchar(30)")
            .IsRequired();

            login.HasIndex(x => x.Value, "Unique_Key_Login_UserAccount").IsUnique();
        });

        builder.OwnsOne(x => x.PasswordHash, password =>
        {
            password.Property(x => x.Value)
            .HasColumnName("PasswordHash")
            .HasColumnType("Nvarchar(30)")
            .IsRequired();
        });

        builder.OwnsOne(x => x.Email, email =>
        {
            email.Property(x => x.Value)
            .HasColumnName("Email")
            .HasColumnType("Nvarchar(254)")
            .IsRequired();

            email.HasIndex(x => x.Value, "Unique_Key_Email_UserAccount").IsUnique();
        });

        builder.OwnsOne(x => x.PhoneNumber, phone_number =>
        {
            phone_number.Property(x => x.Value)
            .HasColumnName("PhoneNumber")
            .HasColumnType("Nvarchar(20)")
            .IsRequired();

            phone_number.HasIndex(x => x.Value, "Unique_PhoneNumber_Login_UserAccount").IsUnique();
        });

        builder.OwnsOne(x => x.BirthDate, birth_date =>
       {
           birth_date.Property(x => x.Value)
           .HasColumnName("BirthDate")
           .HasColumnType("SmallDateTime")
           .IsRequired();
       });


        builder.OwnsOne(x => x.CreateAt, create_at =>
        {
            create_at.Property(x => x.Value)
            .HasColumnName("BirthDate")
            .HasColumnType("SmallDateTime")
            .IsRequired();
        });

        builder.OwnsOne(x => x.Active, active =>
      {
          active.Property(x => x.Value)
          .HasColumnName("Active")
          .HasColumnType("Bit")
          .IsRequired();
      });

        builder.OwnsOne(x => x.Role, role =>
        {
            role.Property(x => x.Value)
            .HasColumnName("Role")
            .HasColumnType("int")
            .IsRequired();
        });
    }
}