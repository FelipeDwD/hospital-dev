using Hospital.WebApi.Infra.Data.Context;
using Hospital.WebApi.Infra.Data.Tests.FakeData;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Hospital.WebApi.Infra.Data.Tests.DbInMemory
{
    public class DbInMemorySetup
    {
        private ApplicationDbContext _dbContext;

        public DbInMemorySetup()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite(connection)
                .Options;

            _dbContext = new ApplicationDbContext(options);
            InsertFakeData();
        }

        public ApplicationDbContext GetContext() =>
            _dbContext;

        private void InsertFakeData()
        {
            if(_dbContext.Database.EnsureCreated())
            {
                _dbContext.Contact.AddRange(ContactFakeData.Get());
            }
            _dbContext.SaveChanges();
        }
    }
}
