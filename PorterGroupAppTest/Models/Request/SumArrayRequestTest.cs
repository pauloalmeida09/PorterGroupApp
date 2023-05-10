using Microsoft.Extensions.Logging;
using Moq;
using PorterGroupApp.Models.Request;
using PorterGroupApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PorterGroupAppTest.Models.Request
{
    public class SumArrayRequestTest
    {
        [Fact]
        public void SumArrayRequest_Create()
        {
            List<int> numbers = new List<int>();

            Random randNum = new Random();

            for (int i = 0; i <= 10; i++)
                numbers.Add(randNum.Next(1, 1000));

            var objectReturn = new SumArrayRequest(numbers);

            Assert.NotNull(objectReturn);
            Assert.True(objectReturn.Numbers == numbers);
        }
    }
}
