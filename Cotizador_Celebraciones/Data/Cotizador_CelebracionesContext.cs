using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cotizador_Celebraciones.Models
{
    public class Cotizador_CelebracionesContext : DbContext
    {
        public Cotizador_CelebracionesContext (DbContextOptions<Cotizador_CelebracionesContext> options)
            : base(options)
        {
        }

        public DbSet<Cotizador_Celebraciones.Models.Cotizacion> Cotizacion { get; set; }
    }
}
