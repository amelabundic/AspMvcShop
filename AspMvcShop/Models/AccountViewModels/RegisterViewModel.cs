using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcShop.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Unesi email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Unesi ime")]
        [StringLength(30, ErrorMessage = "Maksimalno 30 karaktera")]
        public string Ime { get; set; }

        [Required(ErrorMessage = "Unesi prezime")]
        [StringLength(30, ErrorMessage = "Maksimalno 30 karaktera")]
        public string Prezime { get; set; }

        [Required(ErrorMessage = "Unesi drzavu")]
        [StringLength(30, ErrorMessage = "Maksimalno 30 karaktera")]
        public string Drzava { get; set; }

        [Required(ErrorMessage = "Unesi grad")]
        [StringLength(30, ErrorMessage = "Maksimalno 30 karaktera")]
        public string Grad { get; set; }

        [Required(ErrorMessage = "Unesi adresu")]
        [StringLength(100, ErrorMessage = "Maksimalno 100 karaktera")]
        public string Adresa { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "Lozinka")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potvrdi lozinku")]
        [Compare("Password", ErrorMessage = "Potvrda ne odgovara lozinci.")]
        public string ConfirmPassword { get; set; }
    }
}
