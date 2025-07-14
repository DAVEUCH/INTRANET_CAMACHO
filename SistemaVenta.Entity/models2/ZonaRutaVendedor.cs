using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ZonaRutaVendedor
    {
        public int Pkid { get; set; }
        public int IdrutaVendedor { get; set; }
        public int Idzona { get; set; }
        public int? NumeroSemanas { get; set; }
        public DateTime? FechaInicio { get; set; }

        public virtual RutaVendedor IdrutaVendedorNavigation { get; set; } = null!;
        public virtual Zona IdzonaNavigation { get; set; } = null!;
    }
}
