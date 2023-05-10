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
    public class ObjectUserRequestTest
    {
        [Fact]
        public void ObjectUserRequest_Create()
        {
            string name = "Paulo";
            int age = 26;

            var objectReturn = new ObjectUserRequest(name, age);


            Assert.NotNull(objectReturn);
            Assert.True(objectReturn.Name == name);
            Assert.True(objectReturn.Age == age);
        }
    }
}
