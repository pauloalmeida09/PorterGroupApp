using PorterGroupApp.Models.Request;
using PorterGroupApp.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PorterGroupAppTest.Models.Response
{
    public class OperationsMathResponseTest
    {
        [Fact]
        public void OperationsMathResponse_Create()
        {
            int result = 62;

            var objectReturn = new OperationsMathResponse(result);

            Assert.NotNull(objectReturn);
            Assert.True(objectReturn.Result == result);
        }

    }
}
