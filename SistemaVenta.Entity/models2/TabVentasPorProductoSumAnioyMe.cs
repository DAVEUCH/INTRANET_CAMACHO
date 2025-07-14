using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorProductoSumAnioyMe
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int? Año { get; set; }
        public int? Semestre { get; set; }
        public int? Trimestre { get; set; }
        public int? Mes { get; set; }
        public decimal? TotVtas { get; set; }
        public decimal? ValorUnitProm { get; set; }
    }
}
