using Xunit;

namespace Hospital.WebApi.Infra.Data.Tests.Repository.ContactRepositoryTests
{
    public class GetByCellPhoneAsync : ContactRepositoryTest
    {
        [Fact]
        public void ContactRepository_GetByCellPhoneAsync_GivenExistingCellPhone_MustReturnContactWhoHasTheCellPhone()
        {
            //Arrange
            var cellPhone = "(11)90000-1657";
            //Act
            var actual = _repository.GetByCellPhoneAsync(cellPhone);
            //Assert
            Assert.NotNull(actual);
            Assert.Equal(cellPhone, actual.Result.CellPhone);
        }
    }
}
