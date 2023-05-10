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
    public class OperationMathResolveRepositoryTest
    {
        [Fact]
        public void ResolvedOperatingMath_Success()
        {
            OperationsMathRequest request = new OperationsMathRequest();
            request.Operation = "1+5*2/2";

            Mock<ILogger<OperationMathResolveRepository>> mockLogger = new Mock<ILogger<OperationMathResolveRepository>>();
            OperationMathResolveRepository repository = new OperationMathResolveRepository(mockLogger.Object);

            var response = repository.ResolveMathOperationStringArray(request);


            Assert.IsType<int>(response);
            Assert.True(response == 6);
        }

        [Fact]
        public void ResolvedOperatingMath_Error()
        {
            try
            {

                OperationsMathRequest request = new OperationsMathRequest();
                request.Operation = "1+5*2/0";

                Mock<ILogger<OperationMathResolveRepository>> mockLogger = new Mock<ILogger<OperationMathResolveRepository>>();
                OperationMathResolveRepository repository = new OperationMathResolveRepository(mockLogger.Object);

                var response = repository.ResolveMathOperationStringArray(request);
            }
            catch (Exception ex)
            {
                return;
            }

        }
    }
}
