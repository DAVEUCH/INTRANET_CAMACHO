using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoSumAño2016
    {
        public int? Año { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? Totaño { get; set; }
        public decimal? Promaño { get; set; }
        public DateTime? UltFecVtaAño { get; set; }
    }
}
