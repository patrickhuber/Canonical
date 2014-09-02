using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Canonical.WebApp.Models.Manage
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
    }
}