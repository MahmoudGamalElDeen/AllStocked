﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllStocked.Models
{
    public class RegisterViewModel
    {
            [Required]
            public string Name { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [DataType(DataType.Password)]
            [StringLength(150, MinimumLength = 6)]
            [Required]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "Your Passwords must match")]
            [Display(Name = "Confirm Pass")]
            public string ConfirmPassword { get; set; }
        
    }
}