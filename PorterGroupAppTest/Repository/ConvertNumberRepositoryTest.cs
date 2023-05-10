using Microsoft.Extensions.Logging;
using Moq;
using PorterGroupApp.Models.Request;
using PorterGroupApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PorterGroupAppTest.Repository
{
    public class ConvertNumberRepositoryTest
    {
        [Fact]
        public void ConvertNumberToWord_Unit_Succsess()
        {
            int number = 6;
            string numberWord = "seis";

            NumbersToWordRequest request = new NumbersToWordRequest();
            request.Number = number;

            Mock<ILogger<ConvertNumberRepository>> mockLogger = new Mock<ILogger<ConvertNumberRepository>>();
            ConvertNumberRepository convert = new ConvertNumberRepository(mockLogger.Object);

            var response = convert.ConvertNumberToWord(request);


            Assert.True(response == numberWord);
        }
        [Fact]
        public void ConvertNumberToWord_Ten_Succsess()
        {
            int number = 55;
            string numberWord = "cinquenta e cinco";

            NumbersToWordRequest request = new NumbersToWordRequest();
            request.Number = number;

            Mock<ILogger<ConvertNumberRepository>> mockLogger = new Mock<ILogger<ConvertNumberRepository>>();
            ConvertNumberRepository convert = new ConvertNumberRepository(mockLogger.Object);

            var response = convert.ConvertNumberToWord(request);


            Assert.True(response == numberWord);
        }
        [Fact]
        public void ConvertNumberToWord_Hunred_Succsess()
        {
            int number = 137;
            string numberWord = "cento e trinta e sete";

            NumbersToWordRequest request = new NumbersToWordRequest();
            request.Number = number;

            Mock<ILogger<ConvertNumberRepository>> mockLogger = new Mock<ILogger<ConvertNumberRepository>>();
            ConvertNumberRepository convert = new ConvertNumberRepository(mockLogger.Object);

            var response = convert.ConvertNumberToWord(request);


            Assert.True(response == numberWord);
        }
        [Fact]
        public void ConvertNumberToWord_Thousand_Succsess()
        {
            int number = 9831;
            string numberWord = "nove mil e oitocentos e trinta e um";

            NumbersToWordRequest request = new NumbersToWordRequest();
            request.Number = number;

            Mock<ILogger<ConvertNumberRepository>> mockLogger = new Mock<ILogger<ConvertNumberRepository>>();
            ConvertNumberRepository convert = new ConvertNumberRepository(mockLogger.Object);

            var response = convert.ConvertNumberToWord(request);


            Assert.True(response == numberWord);
        }


        [Fact]
        public void ConvertNumberToWord_LimitNumber_Error()
        {
            int number = 10000;
            string responseNumberError = "Não é possivel converter Number maior de 4 digitos";

            NumbersToWordRequest request = new NumbersToWordRequest();
            request.Number = number;

            Mock<ILogger<ConvertNumberRepository>> mockLogger = new Mock<ILogger<ConvertNumberRepository>>();
            ConvertNumberRepository convert = new ConvertNumberRepository(mockLogger.Object);

            var response = convert.ConvertNumberToWord(request);


            Assert.True(response == responseNumberError);
        }
    }
}
