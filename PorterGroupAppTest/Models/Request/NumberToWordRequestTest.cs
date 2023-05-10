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
    public class NumberToWordRequestTest
    {
        [Fact]
        public void NumberToWordRequest_Create()
        {
            int numberToWord = 654;

            var objectReturn = new NumbersToWordRequest(numberToWord);

            Assert.NotNull(objectReturn);
            Assert.True(objectReturn.Number == numberToWord);
        }
    }
}
