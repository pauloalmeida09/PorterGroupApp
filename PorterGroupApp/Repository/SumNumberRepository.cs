using Microsoft.Extensions.Logging;
using PorterGroupApp.Interfaces;
using PorterGroupApp.Models.Request;
using System;
using System.Linq;

namespace PorterGroupApp.Repository
{
    public class SumNumberRepository : ISumNumberRepository
    {
        private readonly ILogger<SumNumberRepository> _logger;

        public SumNumberRepository(ILogger<SumNumberRepository> logger)
        {
            _logger = logger;
        }

        public int SumNumbersArray(SumArrayRequest payload)
        {
            try
            {
                int response = payload.Numbers.Sum();

                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw;
            }

        }
    }
}
