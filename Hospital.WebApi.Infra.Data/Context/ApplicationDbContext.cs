using Hospital.WebApi.Domain.Entities;
using Hospital.WebApi.Infra.Data.Map;
using Microsoft.EntityFrameworkCore;

namespace Hospital.WebApi.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {}

        public DbSet<ContactModel> Contact { get; set; }
        public DbSet<LoginModel> Login { get; set; }
        public DbSet<UserModel> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new LoginMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
