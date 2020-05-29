using System;
using System.Linq;
using Xunit;

namespace EmailApp.BL.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void SendEmail_ValidatesEmail()
        {
            //Arrange
            var send = new EmailService();
            //Act
            int minimalCountEmailAdress = 7; 
            //Assert
            Assert.True(minimalCountEmailAdress <= Constants.MESSAGE_SENDER_ADDRESS.Count());
        }
    }
}
