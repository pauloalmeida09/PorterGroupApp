using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Logging;
using Moq;
using PorterGroupApp.Controllers;
using PorterGroupApp.Interfaces;
using PorterGroupApp.Models.Request;
using PorterGroupApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PorterGroupAppTest.Controllers
{
    public class PorterGroupControllerTest
    {
        public PorterGroupController StartupController(Mock<ILogger<PorterGroupController>> logger = null,
                                     Mock<IConvertNumberRepository> convertNumberRepository = null,
                                     Mock<ISumNumberRepository> sumNumberRepository = null,
                                     Mock<IOperationMathResolveRepository> operationMathResolveRepository = null,
                                     Mock<IListObjectUnicRepository> listObjectUnicRepository = null)
        {
            var mockLogger = logger == null ? new Mock<ILogger<PorterGroupController>>() : logger;
            var mockConverterNumber = convertNumberRepository == null ? new Mock<IConvertNumberRepository>() : convertNumberRepository;
            var mockSumNumbers = sumNumberRepository == null ? new Mock<ISumNumberRepository>() : sumNumberRepository;
            var mockOperationMath = operationMathResolveRepository == null ? new Mock<IOperationMathResolveRepository>() : operationMathResolveRepository;
            var mockListObject = listObjectUnicRepository == null ? new Mock<IListObjectUnicRepository>() : listObjectUnicRepository;

            return new PorterGroupController(mockLogger.Object,
                                             mockConverterNumber.Object,
                                             mockSumNumbers.Object,
                                             mockOperationMath.Object,
                                             mockListObject.Object);

        }

        [Fact]
        public void ControllerPorterGroup_NumbersToWord_Succsess()
        {
            try
            {
                int numberToWord = 12;
                string wordNumber = "doze";

                var objectReturn = new NumbersToWordRequest(numberToWord);
                
                Mock<IConvertNumberRepository> mockConvert = new Mock<IConvertNumberRepository>();
                mockConvert.Setup(a => a.ConvertNumberToWord(objectReturn)).Returns(wordNumber);
                
                var controllerPorterGroup = StartupController(convertNumberRepository:mockConvert);


                IActionResult response = controllerPorterGroup.NumbersToWord(objectReturn);

                return;
            }
            catch (Exception ex)
            {

            }

        }
        [Fact]
        public void ControllerPorterGroup_SumArray_Succsess()
        {
            try
            {
                int result = 305;
                SumArrayRequest request = new SumArrayRequest();
                request.Numbers = new List<int> { 1, 65, 50, 164, 25 };


                Mock<ISumNumberRepository> mockSumArray = new Mock<ISumNumberRepository>();
                mockSumArray.Setup(a => a.SumNumbersArray(request)).Returns(result);

                var controllerPorterGroup = StartupController(sumNumberRepository: mockSumArray);


                IActionResult response = controllerPorterGroup.SumArray(request);

                return;
            }
            catch (Exception ex)
            {

            }

        }
        [Fact]
        public void ControllerPorterGroup_OperationsMath_Succsess()
        {
            try
            {
                int result = 15;
                var request = new OperationsMathRequest("1+2*5");


                Mock<IOperationMathResolveRepository> mockOperationMath = new Mock<IOperationMathResolveRepository>();
                mockOperationMath.Setup(a => a.ResolveMathOperationStringArray(request)).Returns(result);

                var controllerPorterGroup = StartupController(operationMathResolveRepository: mockOperationMath);


                IActionResult response = controllerPorterGroup.OperationsMath(request);

                return;
            }
            catch (Exception ex)
            {

            }

        }
        [Fact]
        public void ControllerPorterGroup_ListUnic_Succsess()
        {
            try
            {
                List<ObjectUserRequest> request = new List<ObjectUserRequest>();
                var object1 = new ObjectUserRequest("Paulo", 15);
                request.Add(object1);
                var object2 = new ObjectUserRequest("Paulo 2", 26);
                request.Add(object2);
                var object3 = new ObjectUserRequest("Paulo", 15);
                request.Add(object3);

                List<ObjectUserRequest> responseMock = new List<ObjectUserRequest>();
                responseMock.Add(object1);
                responseMock.Add(object2);


                Mock<IListObjectUnicRepository> mockListObject = new Mock<IListObjectUnicRepository>();
                mockListObject.Setup(a => a.RemoveRepeatObjects(request)).Returns(responseMock);

                var controllerPorterGroup = StartupController(listObjectUnicRepository: mockListObject);


                IActionResult response = controllerPorterGroup.ListUnic(request);

                return;
            }
            catch (Exception ex)
            {

            }

        }


    }
}
