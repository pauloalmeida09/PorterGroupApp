using System.ComponentModel.DataAnnotations;

namespace PorterGroupApp.Models.Request
{
    public class ObjectUserRequest
    {
        public ObjectUserRequest() { }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int Age { get; set; }

        public ObjectUserRequest(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
