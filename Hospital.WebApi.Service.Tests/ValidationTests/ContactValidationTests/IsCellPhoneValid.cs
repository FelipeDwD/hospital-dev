using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Service.Validations;
using Moq;
using Xunit;

namespace Hospital.WebApi.Service.Tests.ValidationTests.ContactValidationTests
{
    public class IsCellPhoneValid
    {
        [Fact]
        public void ContactValidation_IsCellPhoneValid_GivenCellPhoneValid_MustReturnTrue()
        {
            //Arrange
            var cellPhone = "(11)90167-7954";
            var dddServiceMock = new Mock<IDddService>();
            var contactValidation = new ContactValidation(dddServiceMock.Object);
            //Act
            var response = contactValidation.IsCellPhoneValid(cellPhone);
            //Assert
            Assert.True(response);
        }

        [Fact]
        public void ContactValidation_IsCellPhoneValid_GivenCellPhoneWithOutParentheses_MustReturnFalse()
        {
            //Arrange
            var cellPhone = "1190167-7954";
            var dddServiceMock = new Mock<IDddService>();
            var contactValidation = new ContactValidation(dddServiceMock.Object);
            //Act
            var response = contactValidation.IsCellPhoneValid(cellPhone);
            //Assert
            Assert.False(response);
        }

        [Fact]
        public void ContactValidation_IsCellPhoneValid_GivenCellPhoneWithOutTrace_MustReturnFalse()
        {
            //Arrange
            var cellPhone = "(11)901677954";
            var dddServiceMock = new Mock<IDddService>();
            var contactValidation = new ContactValidation(dddServiceMock.Object);
            //Act
            var response = contactValidation.IsCellPhoneValid(cellPhone);
            //Assert
            Assert.False(response);
        }
        
        [Fact]
        public void ContactValidation_IsCellPhoneValid_GivenCellPhoneWithOutNumberNine_MustReturnFalse()
        {
            //Arrange
            var cellPhone = "(11)1548-9547";
            var dddServiceMock = new Mock<IDddService>();
            var contactValidation = new ContactValidation(dddServiceMock.Object);
            //Act
            var response = contactValidation.IsCellPhoneValid(cellPhone);
            //Assert
            Assert.False(response);
        }

        [Fact]
        public void ContactValidation_IsCellPhoneValid_GivenCellPhoneWithOutDDD_MustReturnFalse()
        {
            //Arrange
            var cellPhone = "()96214-8472";
            var dddServiceMock = new Mock<IDddService>();
            var contactValidation = new ContactValidation(dddServiceMock.Object);
            //Act
            var response = contactValidation.IsCellPhoneValid(cellPhone);
            //Assert
            Assert.False(response);
        }

        [Fact]
        public void ContactValidation_IsCellPhoneValid_GivenCellPhoneWithOneMoreNumberInTheFirstPart_MustReturnFalse()
        {
            //Arrange
            var cellPhone = "(11)916477-1847";
            var dddServiceMock = new Mock<IDddService>();
            var contactValidation = new ContactValidation(dddServiceMock.Object);
            //Act
            var response = contactValidation.IsCellPhoneValid(cellPhone);
            //Assert
            Assert.False(response);
        }

        [Fact]
        public void ContactValidation_IsCellPhoneValid_GivenCellPhoneWithOneMoreNumberInTheSecondPart_MustReturnFalse()
        {
            //Arrange
            var cellPhone = "(11)96871-16485";
            var dddServiceMock = new Mock<IDddService>();
            var contactValidation = new ContactValidation(dddServiceMock.Object);
            //Act
            var response = contactValidation.IsCellPhoneValid(cellPhone);
            //Assert
            Assert.False(response);
        }        
    }
}
