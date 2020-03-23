using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PeSD.Models
{
    public class Disability
    {
        [Key]
        public int DisabilityId { get; set; }

        [Required(ErrorMessage ="El nombre de la discapacidad es requerida")]
        [MaxLength(50)]
        public String DisabilityName { get; set; }

    }
}