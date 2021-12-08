using Hospital.WebApi.Service.Services;
using Xunit;

namespace Hospital.WebApi.Service.Tests.ServicesTests.DddServiceTests
{
    public class GetDdd
    {
        [Fact]
        public void DddService_GetDdd_GivenCellPhone_MustReturnOnlyDdd()
        {
            //Arrange
            var cellPhone = "(00)90000-0000";
            var dddService = new DddService();
            //Act
            var result = dddService.GetDdd(cellPhone);
            //Assert
            Assert.Equal("00", result);
        }
    }
}
