using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooApp.Models
{
    public class Animal


    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Index("AnimalName")]

        public string Name { get; set; }


        [Required]
        [StringLength(50)]
        [Index("OriginName")]

        public string Origin { get; set; }

        [Required]

        public int Quantity { get; set; }

       

        public virtual ICollection<AnimalFood> AnimalFoods { get; set; }


    }
}
