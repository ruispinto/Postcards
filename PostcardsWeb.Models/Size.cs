using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PostcardsWeb.Models
{
    public class Size
    {
        [Key]
        [DisplayName("Id")]
        public int SizeId { get; set; }

        [StringLength(10)]
        [DisplayName("Size")]
        public string Name { get; set; }
    }
}
