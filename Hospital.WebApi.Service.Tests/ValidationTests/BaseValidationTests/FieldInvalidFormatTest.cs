using Hospital.WebApi.Service.Validations;
using Xunit;

namespace Hospital.WebApi.Service.Tests.ValidationTests.BaseValidationTests
{
    public class FieldInvalidFormatTest
    {
        [Fact]
        public void GivenFieldNameMustReturnFullPhrase()
        {
            //Arrange
            var fieldName = "Celular";
            var expected = "O campo Celular não possui um formato válido.";
            //Act
            var actual = BaseValidation.FieldInvalidFormat(fieldName);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
