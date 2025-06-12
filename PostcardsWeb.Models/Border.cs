using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PostcardsWeb.Models
{
    public class Border
    {
        [Key]
        [DisplayName("Id")]
        public int BorderId { get; set; }

        [StringLength(20)]
        [DisplayName("Border type")]
        public string Name { get; set; }
    }
}
