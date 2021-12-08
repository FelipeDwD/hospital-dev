using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Models;
using Hospital.WebApi.Service.Services;
using Moq;
using Xunit;

namespace Hospital.WebApi.Service.Tests.ServicesTests.ContactServiceTests
{
    public class GetByCellPhoneAsync 
    {
        [Fact]
        public void ContactService_GetByCellPhoneAsync_GivenCellPhoneExisting_MustReturnContactWithCellPhone()
        {
            //Arrange
            var cellPhone = "(11)90000-0000";
            var contactRepoReturn = new ContactModel()
            {
                CellPhone = "(11)90000-0000"
            };
            var contactRepoMock = new Mock<IContactRepository>();
            contactRepoMock.Setup(x => x.GetByCellPhoneAsync(cellPhone)).ReturnsAsync(contactRepoReturn);
            var contactService = new ContactService(contactRepoMock.Object);
            //Act
            var contact = contactService.GetByCellPhoneAsync(cellPhone);
            //Assert
            contactRepoMock.Verify(x => x.GetByEmailAsync(cellPhone), Times.Once);
            Assert.NotNull(contact);
            Assert.Equal(cellPhone, contact.Result.CellPhone);
        }

        [Fact]
        public void ContactService_GetByCellPhoneAsync_GivenCellPhoneInexsting_MustReturnNull()
        {
            //Arrange
            var cellPhone = "(11)90000-0000";
            var contactRepoReturn = new ContactModel()
            {
                CellPhone = "(11)90000-0001"
            };
            var contactRepoMock = new Mock<IContactRepository>();
            contactRepoMock.Setup(x => x.GetByCellPhoneAsync(cellPhone)).ReturnsAsync(contactRepoReturn);
            var contactService = new ContactService(contactRepoMock.Object);
            //Act
            var contact = contactService.GetByCellPhoneAsync(cellPhone);
            //Assert
            contactRepoMock.Verify(x => x.GetByCellPhoneAsync(cellPhone), Times.Once);
            Assert.Null(contact);
        }
    }
}
