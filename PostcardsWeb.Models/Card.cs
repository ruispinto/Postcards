using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostcardsWeb.Models
{
    public class Card
    {
        [Key]
        [DisplayName("Id")]
        public int CardId { get; set; }

        [StringLength(50)]
        [DisplayName("Code")]
        public string CardNumber { get; set; }

        [StringLength(250)]
        [DisplayName("Original title")]
        public string NameOrig { get; set; }

        [StringLength(250)]
        [DisplayName("Portuguese title")]
        public string NamePt { get; set; }

        [DisplayName("Is active ?")]
        public bool IsActive { get; set; }

        [DisplayName("Visible ?")]
        public bool IsVisible { get; set; }

        [DisplayName("Favorite ?")]
        public bool IsFav { get; set; }

        [DisplayName("Scanned ?")]
        public bool IsScan { get; set; }

        [StringLength(4)]
        [DisplayName("Printed year")]
        public string PrintYear { get; set; }

        [StringLength(4)]
        [DisplayName("Image year")]
        public string PhotoYear { get; set; }

        [DisplayName("Multi-view ?")]
        public bool IsMultiview { get; set; }

        [StringLength(4)]
        [DisplayName("Number of images")]
        public string TotalPhotos { get; set; }

        [DisplayName("Part of a series ?")]
        public bool IsSeries { get; set; }

        [DisplayName("Puzzle ?")]
        public bool IsPuzzle { get; set; }

        [DisplayName("Identical ?")]
        public bool IsIdentical { get; set; }

        [StringLength(100)]
        [DisplayName("Barcode")]
        public string Barcode { get; set; }

        [DisplayName("Frame ?")]
        public bool HasFrame { get; set; }

        [StringLength(15)]
        [DisplayName("Dimensions (mm)")]
        public string Dimensions { get; set; }

        [DisplayName("Front text")]
        public string FrontText { get; set; }

        [DisplayName("Front text color")]
        public string FrontColor { get; set; }

        [DisplayName("Back text")]
        public string BackText { get; set; }

        [DisplayName("Back text color")]
        public string BackColor { get; set; }

        [StringLength(150)]
        [DisplayName("Webpage")]
        public string WebPage { get; set; }

        [DisplayName("Show front image ?")]
        public bool ShwFrtImg { get; set; }

        [StringLength(100)]
        [DisplayName("Front image")]
        [ValidateNever]
        public string FrontImg { get; set; }

        [DisplayName("Show back image ?")]
        public bool ShwBckImg { get; set; }

        [StringLength(100)]
        [DisplayName("Back image")]
        [ValidateNever]
        public string BackImg { get; set; }

        [DisplayName("Description")]
        [ValidateNever]
        public string CardDesc { get; set; }

        [DisplayName("Tags")]
        public string? CardTags { get; set; }




        [DisplayName("Country (photo)")]
        [ValidateNever]
        public int OriginCountryId { get; set; }

        [ForeignKey("OriginCountryId")]
        [ValidateNever]
        public Country Country1 { get; set; }


        [DisplayName("Country (print)")]
        [ValidateNever]
        public int PrintedCountryId { get; set; }

        [ForeignKey("PrintedCountryId")]
        [ValidateNever]
        public Country Country2 { get; set; }


        [DisplayName("Publisher")]
        [ValidateNever]
        public int CardBrandId { get; set; }

        [ForeignKey("CardBrandId")]
        [ValidateNever]
        public Brand Brand { get; set; }


        [DisplayName("Coloration")]
        [ValidateNever]
        public int CardColorId { get; set; }

        [ForeignKey("CardColorId")]
        [ValidateNever]
        public Coloration Coloration { get; set; }


        [DisplayName("Size")]
        [ValidateNever]
        public int CardSizeId { get; set; }

        [ForeignKey("CardSizeId")]
        [ValidateNever]
        public Size Size { get; set; }


        [DisplayName("Shape")]
        [ValidateNever]
        public int CardShapeId { get; set; }

        [ForeignKey("CardShapeId")]
        [ValidateNever]
        public Shape Shape { get; set; }


        [DisplayName("Material")]
        [ValidateNever]
        public int CardMatId { get; set; }

        [ForeignKey("CardMatId")]
        [ValidateNever]
        public Material Material { get; set; }


        [DisplayName("Border")]
        [ValidateNever]
        public int CardBorderId { get; set; }

        [ForeignKey("CardBorderId")]
        [ValidateNever]
        public Border Border { get; set; }


        [DisplayName("Orientation (front)")]
        [ValidateNever]
        public int FrontOrientId { get; set; }

        [ForeignKey("FrontOrientId")]
        [ValidateNever]
        public Orientation Orientation1 { get; set; }


        [DisplayName("Orientation (back)")]
        [ValidateNever]
        public int BackOrientId { get; set; }

        [ForeignKey("BackOrientId")]
        [ValidateNever]
        public Orientation Orientation2 { get; set; }



        [StringLength(100)]
        [DisplayName("Puzzle image (front)")]
        [ValidateNever]
        public string PuzzleFrtImg { get; set; }

        [StringLength(10)]
        [DisplayName("Postcard number")]
        [ValidateNever]
        public string Number { get; set; }

        [DisplayName("Need replacement ?")]
        [ValidateNever]
        public bool NeedReplace { get; set; }

        [ValidateNever]
        public DateTime RegTime { get; set; } = DateTime.UtcNow;

        [StringLength(250)]
        [DisplayName("English title")]
        public string NameEn { get; set; } = "";

        [DisplayName("Front text")]
        public string FrontTextEn { get; set; }

        [DisplayName("Front text color")]
        public string FrontColorEn { get; set; }

        [DisplayName("Back text")]
        public string BackTextEn { get; set; }

        [DisplayName("Back text color")]
        public string BackColorEn { get; set; }

        [DisplayName("Front text")]
        public string FrontTextOrg { get; set; }

        [DisplayName("Back text")]
        public string BackTextOrg { get; set; }
    }
}
