using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasPorProductoPdvSumDia
    {
        public int? Año { get; set; }
        public int Idsucursal { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? TotPdv { get; set; }
        public decimal? PromPdv { get; set; }
        public DateTime? UltFecVtaPdv { get; set; }
    }
}
