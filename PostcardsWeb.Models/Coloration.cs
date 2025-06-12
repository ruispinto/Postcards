using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PostcardsWeb.Models
{
    public class Coloration
    {
        [Key]
        [DisplayName("Id")]
        public int ColorId { get; set; }

        [StringLength(15)]
        [DisplayName("Coloration")]
        public string Name { get; set; }
    }
}
