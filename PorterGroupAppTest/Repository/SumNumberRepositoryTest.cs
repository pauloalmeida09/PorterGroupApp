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
    public class SumNumberRepositoryTest
    {
        [Fact]
        public void ResolvedSumNumbers_Success()
        {
            SumArrayRequest request = new SumArrayRequest();
            request.Numbers = new List<int> { 1, 65, 50, 164, 25 };

            Mock<ILogger<SumNumberRepository>> mockLogger = new Mock<ILogger<SumNumberRepository>>();
            SumNumberRepository repository = new SumNumberRepository(mockLogger.Object);

            var response = repository.SumNumbersArray(request);


            Assert.IsType<int>(response);
            Assert.True(response == 305);
        }

        [Fact]
        public void ResolvedSumNumbers_CountHunredNumbers_Success()
        {
            SumArrayRequest request = new SumArrayRequest();
            List<int> numbers = new List<int>();

            Random randNum = new Random();

            for (int i = 0; i <= 100; i++)
                numbers.Add(randNum.Next(1,1000));

            request.Numbers = numbers;

            Mock<ILogger<SumNumberRepository>> mockLogger = new Mock<ILogger<SumNumberRepository>>();
            SumNumberRepository repository = new SumNumberRepository(mockLogger.Object);

            var response = repository.SumNumbersArray(request);


            Assert.NotNull(response);
            Assert.IsType<int>(response);
        }
        [Fact]
        public void ResolvedSumNumbers_CountHunredThousand_Success()
        {
            SumArrayRequest request = new SumArrayRequest();
            List<int> numbers = new List<int>();

            Random randNum = new Random();

            for (int i = 0; i <= 5000; i++)
                numbers.Add(randNum.Next(1, 1000));

            request.Numbers = numbers;

            Mock<ILogger<SumNumberRepository>> mockLogger = new Mock<ILogger<SumNumberRepository>>();
            SumNumberRepository repository = new SumNumberRepository(mockLogger.Object);

            var response = repository.SumNumbersArray(request);


            Assert.NotNull(response);
            Assert.IsType<int>(response);
        }

        [Fact]
        public void ResolvedSumNumbers_CountHunredMillion_Success()
        {
            SumArrayRequest request = new SumArrayRequest();
            List<int> numbers = new List<int>();

            Random randNum = new Random();

            for (int i = 0; i <= 1000000; i++)
                numbers.Add(randNum.Next(1, 1000));

            request.Numbers = numbers;

            Mock<ILogger<SumNumberRepository>> mockLogger = new Mock<ILogger<SumNumberRepository>>();
            SumNumberRepository repository = new SumNumberRepository(mockLogger.Object);

            var response = repository.SumNumbersArray(request);


            Assert.NotNull(response);
            Assert.IsType<int>(response);
        }
    }
}
