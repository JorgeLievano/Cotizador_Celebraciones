using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cotizador_Celebraciones.Models
{
    public class Cliente
    {
        [Key]
        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public int Telefono { get; set; }





    }
}
