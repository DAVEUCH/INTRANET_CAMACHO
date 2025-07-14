using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoSumAnual
    {
        public int? Año { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? PromVtas { get; set; }
        public DateTime? UltVtaFec { get; set; }
        public decimal? TotVtasAño { get; set; }
        public int? TotVtasUlt12Mes { get; set; }
        public int? TotVtasUlt6Mes { get; set; }
        public int? TotVtasUlt3Mes { get; set; }
    }
}
