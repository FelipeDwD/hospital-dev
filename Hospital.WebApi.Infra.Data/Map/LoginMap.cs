
using Hospital.WebApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.WebApi.Infra.Data.Map
{
    public class LoginMap : IEntityTypeConfiguration<LoginModel>
    {
        public void Configure(EntityTypeBuilder<LoginModel> builder)
        {
            builder
                .Ignore(x => x.IdUser);

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Login)
                .IsRequired()
                .HasMaxLength(30);

            builder
                .Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(300);

            builder
                .ToTable("Login");
        }
    }
}
