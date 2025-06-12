using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.Models.ViewModels
{
    public class CardIdentDetailsVM
    {
        public CardIdent CardIdent { get; set; }

        [ValidateNever]
        public Card Card1 { get; set; }


        [ValidateNever]
        public Card Card2 { get; set; }
    }
}
