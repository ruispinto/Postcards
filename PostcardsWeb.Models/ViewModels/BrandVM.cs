using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.Models.ViewModels
{
    public class BrandVM
    {
        public Brand Brand { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> CountryList { get; set; }
    }
}
