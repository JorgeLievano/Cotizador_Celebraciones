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

        [Display(Name ="Nombre de Evento")]
        public string NombreEvento { get; set; }

        
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        public string Lugar { get; set; }

        public int Cliente { get; set; }

        public string Detalles { get; set; }

        


    }
}
