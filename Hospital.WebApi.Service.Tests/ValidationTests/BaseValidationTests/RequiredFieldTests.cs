using Hospital.WebApi.Service.Validations;
using Xunit;

namespace Hospital.WebApi.Service.Tests.ValidationTests.BaseValidationTests
{
    public class RequiredFieldTests
    {
        [Fact]
        public void GivenFieldNameMustReturnFullPhrase()
        {
            //Arrange
            var fieldName = "Nome";
            var expected = "O campo Nome é obrigatório.";
            //Act
            var actual = BaseValidation.RequiredField(fieldName);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
