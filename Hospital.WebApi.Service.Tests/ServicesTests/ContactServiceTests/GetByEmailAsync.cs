using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Models;
using Hospital.WebApi.Service.Services;
using Moq;
using Xunit;

namespace Hospital.WebApi.Service.Tests.ServicesTests.ContactServiceTests
{
    public class GetByEmailAsync
    {
        [Fact]
        public void ContactService_GetByEmailAsync_GivenExistingEmail_MustReturnTheContactWhoHasTheEmail()
        {
            //Arrange
            var email = "teste@gmail.com";
            var contactRepoReturn = new ContactModel()
            {
                Email = "teste@gmail.com"   
            };
            var contactRepoMock = new Mock<IContactRepository>();
            contactRepoMock.Setup(x => x.GetByEmailAsync(email)).ReturnsAsync(contactRepoReturn);
            var contactService = new ContactService(contactRepoMock.Object);
            //Act
            var contact = contactService.GetByEmailAsync(email);
            //Assert
            contactRepoMock.Verify(x => x.GetByEmailAsync(email), Times.Once);
            Assert.NotNull(contact);
            Assert.Equal(email, contact.Result.Email);
        }
    }
}
