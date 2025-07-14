using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VVentasDetalladum
    {
        public decimal? TotalItem { get; set; }
        public DateTime Fecha { get; set; }
        public int Idvendedor { get; set; }
        public int Idproducto { get; set; }
    }
}
