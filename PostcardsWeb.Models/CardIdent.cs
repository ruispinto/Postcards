using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostcardsWeb.Models
{
    public class CardIdent
    {
        [Key]
        [DisplayName("Id")]
        public int IdentId { get; set; }

        [DisplayName("Description in the front")]
        public string? DescFrtIdent { get; set; }

        [DisplayName("Description in the back")]
        public string? DescBckIdent { get; set; }





        [DisplayName("Original code")]
        [ValidateNever]
        public int? CardOrigId { get; set; }

        [ForeignKey("CardOrigId")]
        [ValidateNever]
        public Card Card1 { get; set; }


        [DisplayName("Identical code")]
        [ValidateNever]
        public int? CardIdentId { get; set; }

        [ForeignKey("CardIdentId")]
        [ValidateNever]
        public Card Card2 { get; set; }
    }
}
