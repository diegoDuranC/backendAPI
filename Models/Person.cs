using System.ComponentModel.DataAnnotations;

namespace persona_api.Models
{
    public class Person
    {
        [Key]
        public int CI { get; set; }
        public string Name { get; set; } = null!;
    }
}
