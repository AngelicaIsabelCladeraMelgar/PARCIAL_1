using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialIsabelCladera.Models
{
    public enum RegionType
    {
        America = 10,
        Europa = 20,
        Africa = 30,
        Antartica = 40,
        Oseania = 50
    }
    public enum FlagsType
    {
        Amarillo_rojo_azul = 10,
        Rojo_amarillo_verde = 20,
        Azul_rojo_blanco= 30
    }


    public class Country
    {
        [Key]
        [StringLength(3, ErrorMessage = "The field {0} must contain betwen {2} and {1} characters", MinimumLength = 1)]
        public string alpha3code { get; set; }

        [Display(Name = "Region")]
        public RegionType Region { get; set; }

        [StringLength(24, ErrorMessage = "The field {0} must contain betwen {2} and {1} characters", MinimumLength = 2)]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Display(Name = "Nombre del Pais")]
        public string name { get; set; }

        [Required(ErrorMessage = "Se debe ingrasear este campo")]
        public int area { get; set; }

        public int calllingCode { get; set; }

        [Display(Name = "Idioma")]
        public string Languages { get; set; }

        [Display(Name = "Colores de la bandera")]
        public FlagsType flags { get; set; }
    }
}