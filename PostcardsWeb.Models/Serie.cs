using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostcardsWeb.Models
{
    public class Serie
    {
        [Key]
        [DisplayName("Id")]
        public int SerieId { get; set; }

        [StringLength(4)]
        [DisplayName("Number")]
        public string SerieNumber { get; set; }

        [StringLength(250)]
        [DisplayName("Original title")]
        public string NameOrig { get; set; }

        [StringLength(250)]
        [DisplayName("Portuguese title")]
        public string? NamePt { get; set; }

        [DisplayName("Scanned ?")]
        public bool? IsScan { get; set; }

        [DisplayName("Date")]
        public string? SerieDate { get; set; }

        [StringLength(4)]
        [DisplayName("Printed year")]
        public string? PrintYear { get; set; }

        [StringLength(4)]
        [DisplayName("Photo year")]
        public string? PhotoYear { get; set; }

        [DisplayName("Multi-views ?")]
        public bool? IsMultiview { get; set; }

        [StringLength(4)]
        [DisplayName("Total photos")]
        public string? TotalPhotos { get; set; }

        [DisplayName("Is identical ?")]
        public bool? IsIdentical { get; set; }

        [StringLength(100)]
        [DisplayName("Barcode")]
        public string? Barcode { get; set; }

        [DisplayName("Has frame ?")]
        public bool? HasFrame { get; set; }

        [DisplayName("Front text")]
        public string? FrontText { get; set; }

        [DisplayName("Front text color")]
        public string? FrontColor { get; set; }

        [DisplayName("Back text")]
        public string? BackText { get; set; }

        [DisplayName("Back text color")]
        public string? BackColor { get; set; }

        [StringLength(150)]
        [DisplayName("Webpage")]
        public string? WebPage { get; set; }

        [DisplayName("Show front image ?")]
        public bool? ShwFrtImg { get; set; }

        [StringLength(100)]
        [DisplayName("Front image")]
        [ValidateNever]
        public string? FrontImg { get; set; }

        [DisplayName("Show back image ?")]
        public bool? ShwBckImg { get; set; }

        [StringLength(100)]
        [DisplayName("Back image")]
        [ValidateNever]
        public string? BackImg { get; set; }

        [DisplayName("Description")]
        [ValidateNever]
        public string? SerieDesc { get; set; }

        [DisplayName("Tags")]
        [ValidateNever]
        public string? SerieTags { get; set; }




        [DisplayName("Postal")]
        [ValidateNever]
        public int? SerieCardId { get; set; }

        [ForeignKey("SerieCardId")]
        [ValidateNever]
        public Card Card { get; set; }


        [DisplayName("País (imagem)")]
        [ValidateNever]
        public int? OriginCountryId { get; set; }

        [ForeignKey("OriginCountryId")]
        [ValidateNever]
        public Country Country { get; set; }


        [DisplayName("Coloração")]
        [ValidateNever]
        public int? SerieColorId { get; set; }

        [ForeignKey("SerieColorId")]
        [ValidateNever]
        public Coloration Coloration { get; set; }


        [DisplayName("Orientação (frente)")]
        [ValidateNever]
        public int? FrontOrientId { get; set; }

        [ForeignKey("FrontOrientId")]
        [ValidateNever]
        public Orientation Orientation1 { get; set; }


        [DisplayName("Orientação (verso)")]
        [ValidateNever]
        public int? BackOrientId { get; set; }

        [ForeignKey("BackOrientId")]
        [ValidateNever]
        public Orientation Orientation2 { get; set; }

    }
}
