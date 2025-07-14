using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorProductoSumAnio
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int? Año { get; set; }
        public decimal? TotVtas { get; set; }
    }
}
