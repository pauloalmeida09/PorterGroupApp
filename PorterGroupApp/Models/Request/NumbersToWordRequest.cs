using System.ComponentModel.DataAnnotations;

namespace PorterGroupApp.Models.Request
{
    public class NumbersToWordRequest
    {
        public NumbersToWordRequest() { }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int Number { get; set; }

        public NumbersToWordRequest(int number)
        {
            Number = number;
        }
    }
}
