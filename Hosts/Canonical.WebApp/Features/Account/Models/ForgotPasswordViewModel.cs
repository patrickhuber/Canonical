using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Canonical.WebApp.Features.Account.Models
{    
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
