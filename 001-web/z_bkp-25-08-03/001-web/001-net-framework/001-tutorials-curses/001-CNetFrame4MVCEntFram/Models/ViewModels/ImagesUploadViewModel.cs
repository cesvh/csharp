using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _001_CNetFrame4MVCEntFram.Models.ViewModels
{
    public class ImagesUploadViewModel
    {
        [Required]
        [DisplayName("Archivo 1")]
        public HttpPostedFileBase File1 { get; set; }

        [Required]
        [DisplayName("Archivo 2")]
        public HttpPostedFileBase File2 { get; set; }

        [Required]
        [DisplayName("Mi cadena")]
        public string Cadena { get; set; }
    }
}