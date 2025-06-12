using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PostcardsWeb.Models
{
    public class Material
    {
        [Key]
        [DisplayName("Id")]
        public int MatId { get; set; }

        [StringLength(20)]
        [DisplayName("Material")]
        public string Name { get; set; }
    }
}
