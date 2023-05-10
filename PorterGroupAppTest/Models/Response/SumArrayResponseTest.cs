using PorterGroupApp.Models.Request;
using PorterGroupApp.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PorterGroupAppTest.Models.Response
{
    public class SumArrayResponseTest
    {
        [Fact]
        public void SumArrayResponse_Create()
        {
            int result = 6265;

            var objectReturn = new SumArrayResponse(result);

            Assert.NotNull(objectReturn);
            Assert.True(objectReturn.Result == result);
        }

    }
}
