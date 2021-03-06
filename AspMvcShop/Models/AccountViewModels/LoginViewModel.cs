﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcShop.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Unesi email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Unesi lozinku")]
        [Display(Name ="Lozinka")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
