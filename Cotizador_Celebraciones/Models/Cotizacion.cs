using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cotizador_Celebraciones.Models
{
    public class Cotizacion
    {

        public int Id { get; set; }

        [Display(Name ="Nombre de Evento"),Required(ErrorMessage ="Ingrese un nombre o tipo de evento")]
        public string NombreEvento { get; set; }

        
        [DataType(DataType.Date),Required(ErrorMessage ="Añada una fecha para su evento")]
        public DateTime Fecha { get; set; }
        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        public string Lugar { get; set; }

        [Required(ErrorMessage ="Es necesario agregar su documento de identificación")]
        public int Cliente { get; set; }

        [Required(ErrorMessage ="Es necesario su correo para contactarlo"),Display(Name ="Correo Electronico"),DataType(DataType.EmailAddress)]
        public string CorreoElectronico { get; set; }

        public string Detalles { get; set; }

        


    }
}
