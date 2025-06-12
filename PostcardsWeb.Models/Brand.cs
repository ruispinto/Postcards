using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostcardsWeb.Models
{
    public class Brand
    {
        [Key]
        [DisplayName("Id")]
        public int BrandId { get; set; }

        [StringLength(100)]
        [DisplayName("Brand")]
        public string Name { get; set; }

        [StringLength(500)]
        [DisplayName("Group")]
        public string? CompanyGroup { get; set; }

        [StringLength(20)]
        [DisplayName("Abreviation")]
        public string? BrandAbr { get; set; }

        [StringLength(150)]
        [DisplayName("Webpage")]
        public string? WebPage { get; set; }





        [DisplayName("Country")]
        [ValidateNever]
        public int? BrandCountryId { get; set; }

        [ForeignKey("BrandCountryId")]
        [ValidateNever]
        public Country Country { get; set; }

        [DisplayName("Logo")]
        [ValidateNever]
        public string? BrandImage { get; set; }
    }
}
