using Hospital.WebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hospital.WebApi.Infra.Data.Map
{
    public class ContactMap : IEntityTypeConfiguration<ContactModel>
    {
        public void Configure(EntityTypeBuilder<ContactModel> builder)
        {
            builder
                .Ignore(x => x.IdUser);

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.CellPhone)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .ToTable("Contact");
        }
    }
}
