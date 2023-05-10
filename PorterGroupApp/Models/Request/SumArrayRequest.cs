using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PorterGroupApp.Models.Request
{
    public class SumArrayRequest
    {
        public SumArrayRequest() { }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MaxLength(1000000, ErrorMessage = "Este campo não deve ultrapassar o valor de 1000000 posições.")]
        public List<int> Numbers { get; set; }


        public SumArrayRequest(List<int> numbers) { Numbers = numbers; }
    }
}
