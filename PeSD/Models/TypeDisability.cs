using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PeSD.Models
{
    public class TypeDisability
    {
        [Key]
        public int TypeDisabilityId { get; set; }

        [Required(ErrorMessage ="El nombre de la discapacidad es requerida")]
        [MaxLength(50,ErrorMessage = "La longitud máxima es de 50 caracteres")]
        [Display(Name ="Tipo de discapacidad")]
        public String TypeDisabilityName { get; set; }

    }
}