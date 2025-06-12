using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.Models.ViewModels
{
    public class SerieVM
    {
        public Serie Serie { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> CardList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> CountryList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> ColorationList { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> OrientationList { get; set; }

    }
}
