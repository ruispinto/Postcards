using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PostcardsWeb.Models
{
    public class Orientation
    {
        [Key]
        [DisplayName("Id")]
        public int OrientId { get; set; }

        [StringLength(20)]
        [DisplayName("Orientation")]
        public string Name { get; set; }
    }
}
