using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoAñoyTrimyMese
    {
        public int? Año { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? TotAño { get; set; }
        public decimal? Promaño { get; set; }
        public decimal? Trim1 { get; set; }
        public decimal? Trim2 { get; set; }
        public decimal? Trim3 { get; set; }
        public decimal? Trim4 { get; set; }
        public DateTime? UltFecVtaPdv { get; set; }
        public decimal? Mes1 { get; set; }
        public decimal? Mes2 { get; set; }
        public decimal? Mes3 { get; set; }
        public decimal? Mes4 { get; set; }
        public decimal? Mes5 { get; set; }
        public decimal? Mes6 { get; set; }
        public decimal? Mes7 { get; set; }
        public decimal? Mes8 { get; set; }
        public decimal? Mes9 { get; set; }
        public decimal? Mes10 { get; set; }
        public decimal? Mes11 { get; set; }
        public decimal? Mes12 { get; set; }
    }
}
