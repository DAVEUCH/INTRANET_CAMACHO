using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCantidadEntregadaBonificacion
    {
        public decimal? CantidadEntregada { get; set; }
        public int Idbonificacion { get; set; }
        public int Idpersona { get; set; }
        public DateTime FechaEmision { get; set; }
        public int Idproducto { get; set; }
    }
}
