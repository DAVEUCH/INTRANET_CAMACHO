using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoSumPdv2022
    {
        public int Idsucursal { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? TotPdv { get; set; }
        public decimal? PromPdv { get; set; }
        public DateTime? UltFecVtaPdv { get; set; }
        public int? StockPdv { get; set; }
        public int? TotVtasUlt12Mes { get; set; }
        public int? TotVtasUlt9Mes { get; set; }
        public int? TotVtasUlt6Mes { get; set; }
        public int? TotVtasUlt3Mes { get; set; }
        public int? TotVtasUlt15dias { get; set; }
    }
}
