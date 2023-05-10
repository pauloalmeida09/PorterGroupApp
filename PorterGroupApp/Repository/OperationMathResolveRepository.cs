using Microsoft.Extensions.Logging;
using PorterGroupApp.Interfaces;
using PorterGroupApp.Models.Request;
using System.Data;
using System;

namespace PorterGroupApp.Repository
{
    public class OperationMathResolveRepository : IOperationMathResolveRepository
    {
        private readonly ILogger<OperationMathResolveRepository> _logger;

        public OperationMathResolveRepository(ILogger<OperationMathResolveRepository> logger)
        {
            _logger = logger;
        }

        public int ResolveMathOperationStringArray(OperationsMathRequest payload)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("expression", typeof(string), payload.Operation);
                DataRow row = table.NewRow();
                table.Rows.Add(row);

                var response = row[0];

                return Convert.ToInt32(response);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw ex;
            }

        }
    }
}
