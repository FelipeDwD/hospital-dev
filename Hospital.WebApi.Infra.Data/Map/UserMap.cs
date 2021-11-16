using Hospital.WebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.WebApi.Infra.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<UserModel>
    {
        public void Configure(EntityTypeBuilder<UserModel> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(x => x.Surname)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(x => x.BirthDate)
                .IsRequired()
                .HasColumnType("Date");

            builder
                .HasOne(x => x.Login)
                .WithOne(y => y.User)
                .HasForeignKey<UserModel>(x => x.IdLogin);

            builder
                .HasOne(x => x.Contact)
                .WithOne(y => y.User)
                .HasForeignKey<UserModel>(x => x.IdContact);
        }
    }
}
