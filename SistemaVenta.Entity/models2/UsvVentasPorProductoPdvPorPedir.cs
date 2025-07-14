using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoPdvPorPedir
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? TotVtas { get; set; }
        public decimal? PromVtas { get; set; }
        public decimal? TotPdv { get; set; }
        public decimal? PromPdv { get; set; }
        public int? TotPdvtrim { get; set; }
        public decimal? StockGrupo { get; set; }
        public int? StocPdv { get; set; }
        public DateTime? UltFecVtaPdv { get; set; }
        public string? AlmacenPedir { get; set; }
        public int? StockAPedir { get; set; }
    }
}
