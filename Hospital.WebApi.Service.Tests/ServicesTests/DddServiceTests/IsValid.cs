using Hospital.WebApi.Service.Services;
using Xunit;

namespace Hospital.WebApi.Service.Tests.ServicesTests.DddServiceTests
{
    public class IsValid
    {
        [Theory]
        [InlineData("(68)90000-0000")]
        [InlineData("(82)90000-0000")]
        [InlineData("(96)90000-0000")]
        [InlineData("(92)90000-0000")]
        [InlineData("(71)90000-0000")]
        [InlineData("(85)90000-0000")]
        [InlineData("(61)90000-0000")]
        [InlineData("(27)90000-0000")]
        [InlineData("(62)90000-0000")]
        [InlineData("(98)90000-0000")]
        [InlineData("(65)90000-0000")]
        [InlineData("(67)90000-0000")]
        [InlineData("(31)90000-0000")]
        [InlineData("(91)90000-0000")]
        [InlineData("(83)90000-0000")]
        [InlineData("(41)90000-0000")]
        [InlineData("(86)90000-0000")]
        [InlineData("(21)90000-0000")]
        [InlineData("(84)90000-0000")]
        [InlineData("(51)90000-0000")]
        [InlineData("(69)90000-0000")]
        [InlineData("(95)90000-0000")]
        [InlineData("(47)90000-0000")]
        [InlineData("(11)90000-0000")]
        [InlineData("(79)90000-0000")]
        [InlineData("(63)90000-0000")]
        public void DddService_IsValid_GivenDddsValids_MustReturnTrue(string cellPhone)
        {
            //Arrange
            var dddService = new DddService();
            //Act
            var result = dddService.IsValid(cellPhone);            
            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("(01)90000-0000")]
        [InlineData("(02)90000-0000")]
        [InlineData("(03)90000-0000")]
        [InlineData("(04)90000-0000")]
        [InlineData("(05)90000-0000")]
        [InlineData("(06)90000-0000")]
        [InlineData("(07)90000-0000")]
        [InlineData("(08)90000-0000")]
        [InlineData("(09)90000-0000")]
        [InlineData("(10)90000-0000")]        
        [InlineData("(12)90000-0000")]
        [InlineData("(13)90000-0000")]
        [InlineData("(14)90000-0000")]
        [InlineData("(15)90000-0000")]
        [InlineData("(16)90000-0000")]
        [InlineData("(17)90000-0000")]
        [InlineData("(18)90000-0000")]
        [InlineData("(19)90000-0000")]
        [InlineData("(20)90000-0000")]        
        [InlineData("(22)90000-0000")]
        [InlineData("(23)90000-0000")]
        [InlineData("(24)90000-0000")]
        [InlineData("(25)90000-0000")]
        [InlineData("(26)90000-0000")]        
        [InlineData("(28)90000-0000")]
        [InlineData("(29)90000-0000")]
        [InlineData("(30)90000-0000")]        
        [InlineData("(32)90000-0000")]
        [InlineData("(33)90000-0000")]
        [InlineData("(34)90000-0000")]
        [InlineData("(35)90000-0000")]
        [InlineData("(36)90000-0000")]
        [InlineData("(38)90000-0000")]
        [InlineData("(39)90000-0000")]
        [InlineData("(40)90000-0000")]        
        [InlineData("(42)90000-0000")]
        [InlineData("(43)90000-0000")]
        [InlineData("(44)90000-0000")]
        [InlineData("(45)90000-0000")]
        [InlineData("(46)90000-0000")]        
        [InlineData("(48)90000-0000")]
        [InlineData("(49)90000-0000")]
        [InlineData("(50)90000-0000")]        
        [InlineData("(52)90000-0000")]
        [InlineData("(53)90000-0000")]
        [InlineData("(54)90000-0000")]
        [InlineData("(55)90000-0000")]
        [InlineData("(56)90000-0000")]
        [InlineData("(57)90000-0000")]
        [InlineData("(58)90000-0000")]
        [InlineData("(59)90000-0000")]
        [InlineData("(60)90000-0000")]                        
        [InlineData("(64)90000-0000")]        
        [InlineData("(66)90000-0000")]                        
        [InlineData("(70)90000-0000")]        
        [InlineData("(72)90000-0000")]
        [InlineData("(73)90000-0000")]
        [InlineData("(74)90000-0000")]
        [InlineData("(75)90000-0000")]
        [InlineData("(76)90000-0000")]
        [InlineData("(77)90000-0000")]
        [InlineData("(78)90000-0000")]        
        [InlineData("(80)90000-0000")]
        [InlineData("(81)90000-0000")]                                        
        [InlineData("(87)90000-0000")]
        [InlineData("(88)90000-0000")]
        [InlineData("(89)90000-0000")]
        [InlineData("(90)90000-0000")]           
        [InlineData("(93)90000-0000")]
        [InlineData("(94)90000-0000")]           
        [InlineData("(97)90000-0000")]        
        [InlineData("(99)90000-0000")]
        public void DddService_IsValid_GivenDddsInvalids_MustReturnFalse(string cellPhone)
        {
            //Arrange
            var dddService = new DddService();
            //Act
            var result = dddService.IsValid(cellPhone);
            //Assert
            Assert.False(result);
        }
    }
}
