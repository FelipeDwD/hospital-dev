using Hospital.WebApi.Infra.Data.Context;
using Hospital.WebApi.Infra.Data.Tests.DbInMemory;

namespace Hospital.WebApi.Infra.Data.Tests.Shared
{
    public abstract class MethodTestBase                                                     
    {
        protected ApplicationDbContext _dbContext;   
        public MethodTestBase()
        {
            var dbInMemorySetup = new DbInMemorySetup();
            _dbContext = dbInMemorySetup.GetContext();            
        }
    }
}
