using Hospital.WebApi.Infra.Data.Repository;
using Hospital.WebApi.Infra.Data.Tests.Shared;

namespace Hospital.WebApi.Infra.Data.Tests.Repository.ContactRepositoryTests
{
    public abstract class ContactRepositoryTest : MethodTestBase
    {
        protected readonly ContactRepository _repository;

        public ContactRepositoryTest()
        {
            _repository = new ContactRepository(_dbContext);
        }
    }
}
