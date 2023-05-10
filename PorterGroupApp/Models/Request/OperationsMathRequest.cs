using System.ComponentModel.DataAnnotations;

namespace PorterGroupApp.Models.Request
{
    public class OperationsMathRequest
    {
        public OperationsMathRequest() { }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Operation { get; set; }

        public OperationsMathRequest(string operation) { Operation = operation; }

    }
}
