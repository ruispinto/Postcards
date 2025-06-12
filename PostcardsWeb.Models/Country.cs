using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PostcardsWeb.Models
{
    public class Country
    {
        [Key]
        [DisplayName("Id")]
        public int CountryId { get; set; }

        [StringLength(150)]
        [DisplayName("Country (PT)")]
        public string NamePt { get; set; }

        [StringLength(150)]
        [DisplayName("Country (EN)")]
        public string NameEn { get; set; }

        [StringLength(2)]
        [DisplayName("ISO region")]
        public string IsoRegion { get; set; }

        [StringLength(3)]
        [DisplayName("ISO language")]
        public string IsoLang { get; set; }

        [DisplayName("Description")]
        public string CountryDesc { get; set; }
    }
}
