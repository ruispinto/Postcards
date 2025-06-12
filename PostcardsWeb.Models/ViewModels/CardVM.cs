using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.Models.ViewModels
{
    public class CardVM
    {
        public Card Card { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> BorderList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> BrandList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ColorationList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> CountryList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> MaterialList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> OrientationList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ShapeList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> SizeList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> TagList { get; set; }

    }
}
