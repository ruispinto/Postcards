using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcardsWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(30)]
        [DisplayName("Name")]
        [Required]
        public string Name { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }
}
