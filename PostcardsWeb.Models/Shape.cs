using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PostcardsWeb.Models
{
    public class Shape
    {
        [Key]
        [DisplayName("Id")]
        public int ShapeId { get; set; }

        [StringLength(15)]
        [DisplayName("Shape")]
        public string Name { get; set; }
    }
}
