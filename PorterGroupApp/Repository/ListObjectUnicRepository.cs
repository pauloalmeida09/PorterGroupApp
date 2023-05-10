using Microsoft.Extensions.Logging;
using PorterGroupApp.Interfaces;
using PorterGroupApp.Models.Request;
using System.Collections.Generic;
using System.Linq;
using System;
using SuperLinq;

namespace PorterGroupApp.Repository
{
    public class ListObjectUnicRepository : IListObjectUnicRepository
    {
        private readonly ILogger<ListObjectUnicRepository> _logger;

        public ListObjectUnicRepository(ILogger<ListObjectUnicRepository> logger)
        {
            _logger = logger;
        }

        public List<ObjectUserRequest> RemoveRepeatObjects(List<ObjectUserRequest> payload)
        {
            try
            {

                var response = payload.DistinctBy(a => (a.Name, a.Age)).ToList();

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
