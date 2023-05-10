using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PorterGroupApp.Interfaces;
using PorterGroupApp.Models.Request;
using PorterGroupApp.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PorterGroupApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PorterGroupController : ControllerBase
    {
        private readonly ILogger<PorterGroupController> _logger;
        private readonly IConvertNumberRepository _convertNumberRepository;
        private readonly ISumNumberRepository _sumNumberRepository;
        private readonly IOperationMathResolveRepository _operationMathResolveRepository;
        private readonly IListObjectUnicRepository _listObjectUnicRepository;

        public PorterGroupController(ILogger<PorterGroupController> logger,
                                     IConvertNumberRepository convertNumberRepository,
                                     ISumNumberRepository sumNumberRepository,
                                     IOperationMathResolveRepository operationMathResolveRepository,
                                     IListObjectUnicRepository listObjectUnicRepository)
        {
            _logger = logger;
            _convertNumberRepository = convertNumberRepository;
            _sumNumberRepository = sumNumberRepository;
            _operationMathResolveRepository = operationMathResolveRepository;
            _listObjectUnicRepository = listObjectUnicRepository;
        }
        [HttpPost("NumbersToWord")]
        public IActionResult NumbersToWord(NumbersToWordRequest payload)
        {
            try
            {
                var response = new NumbersToWordResponse
                {
                    WordNumber = _convertNumberRepository.ConvertNumberToWord(payload)
                };


                return Ok(response);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                var response = new
                {
                    Result = "Não foi possível efetuar a conversão do numero recebido de forma alfabética."
                };
                return BadRequest(response);
            }

        }
        [HttpPost("SumArray")]
        public IActionResult SumArray(SumArrayRequest payload)
        {
            try
            {
                var response = new SumArrayResponse
                {
                    Result = _sumNumberRepository.SumNumbersArray(payload)
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                var response = new
                {
                    Result = "Não foi possível efetuar soma dos inteiros."
                };
                return BadRequest(response);
            }
        }

        [HttpPost("OperationsMath")]
        public IActionResult OperationsMath(OperationsMathRequest payload)
        {
            try
            {
                var response = new OperationsMathResponse
                {
                    Result = _operationMathResolveRepository.ResolveMathOperationStringArray(payload)
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                var response = new
                {
                    Result = "Não foi possível efetuar o calculo, o mesmo não resulta e numero inteiro e/ou houve uma tentativa de divisão por 0."
                };
                return BadRequest(response);
            }
        }

        [HttpPost("ListUnic")]
        public IActionResult ListUnic(List<ObjectUserRequest> payload)
        {
            try
            {
                var response = _listObjectUnicRepository.RemoveRepeatObjects(payload);

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return BadRequest(ex);
            }
        }
    }
}
