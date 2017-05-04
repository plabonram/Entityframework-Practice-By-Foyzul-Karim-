
using System.ComponentModel.DataAnnotations;

namespace EntityframeworkPracticeByFoyzulKarim.Models
{
    public class Animal
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Food { get; set; }

        [Required]
        [MaxLength(255)]
        public string Origin { get; set; }

        [Required]

        public int Quantity { get; set; }

    }
}