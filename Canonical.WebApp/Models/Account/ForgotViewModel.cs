using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Canonical.WebApp.Models.Account
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}