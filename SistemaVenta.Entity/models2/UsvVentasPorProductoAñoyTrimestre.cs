using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoAñoyTrimestre
    {
        public int? Año { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? TotAño { get; set; }
        public decimal? Trim1 { get; set; }
        public decimal? Trim2 { get; set; }
        public decimal? Trim3 { get; set; }
        public decimal? Trim4 { get; set; }
        public decimal? PromPdv { get; set; }
        public DateTime? UltFecVtaPdv { get; set; }
    }
}
