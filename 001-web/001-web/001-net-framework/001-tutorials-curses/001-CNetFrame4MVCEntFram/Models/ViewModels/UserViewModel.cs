using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _001_CNetFrame4MVCEntFram.Models.ViewModels
{
    public class UserViewModel
    {
        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {2} caracteres y un máximo de {1} caracteres.", MinimumLength = 5)]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Confirmar contraseña")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "La contraseña y la confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Edad")]
        public int Edad { get; set; }
    }
    public class EditUserViewModel
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "El {0} debe tener al menos {2} caracteres y un máximo de {1} caracteres.", MinimumLength = 5)]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Confirmar contraseña")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "La contraseña y la confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Edad")]
        public int Edad { get; set; }
    }
}