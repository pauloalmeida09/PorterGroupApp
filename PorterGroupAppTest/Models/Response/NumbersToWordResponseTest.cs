using PorterGroupApp.Models.Request;
using PorterGroupApp.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PorterGroupAppTest.Models.Response
{
    public class NumbersToWordResponseTest
    {
        [Fact]
        public void NumbersToWordResponse_Create()
        {
            string wordNumer = "cinquenta e dois";

            var objectReturn = new NumbersToWordResponse(wordNumer);

            Assert.NotNull(objectReturn);
            Assert.True(objectReturn.WordNumber == wordNumer);
        }

    }
}
