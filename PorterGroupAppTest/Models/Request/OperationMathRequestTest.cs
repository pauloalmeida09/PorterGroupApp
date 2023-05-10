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
    public class OperationMathRequestTest
    {
        [Fact]
        public void NumberToWordRequest_Create()
        {
            string operationString = "1+5*2";

            var objectReturn = new OperationsMathRequest(operationString);

            Assert.NotNull(objectReturn);
            Assert.True(objectReturn.Operation == operationString);
        }
    }
}
