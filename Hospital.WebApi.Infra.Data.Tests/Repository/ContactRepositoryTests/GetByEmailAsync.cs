using Xunit;

namespace Hospital.WebApi.Infra.Data.Tests.Repository.ContactRepositoryTests
{
    public class GetByEmailAsync : ContactRepositoryTest
    {
        [Fact]
        public void ContactRepository_GetByEmailAsync_GivenExistingEmail_MustReturnTheContactWhoHasTheEmail()
        {
            //Arranje
            var email = "teste@gmail.com";
            //Act
            var actual = _repository.GetByEmailAsync(email);
            //Assert
            Assert.NotNull(actual);
            Assert.Equal(email, actual.Result.Email);
        }
    }
}
