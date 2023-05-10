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
    public class ListObjectUnicRepositoryTest
    {
        [Fact]
        public void ListObjectUnic_ElimanateOneObject_Success()
        {
            List<ObjectUserRequest> request = new List<ObjectUserRequest>();
            var object1 = new ObjectUserRequest("Paulo",15);
            request.Add(object1);
            var object2 = new ObjectUserRequest("Paulo 2", 26);
            request.Add(object2);
            var object3 = new ObjectUserRequest("Paulo", 15);
            request.Add(object3);

            Mock<ILogger<ListObjectUnicRepository>> mockLogger = new Mock<ILogger<ListObjectUnicRepository>>();
            ListObjectUnicRepository repository = new ListObjectUnicRepository(mockLogger.Object);

            var response = repository.RemoveRepeatObjects(request);


            Assert.IsType<List<ObjectUserRequest>>(response);
            Assert.True(response.Count == 2);
        }
    }
}
