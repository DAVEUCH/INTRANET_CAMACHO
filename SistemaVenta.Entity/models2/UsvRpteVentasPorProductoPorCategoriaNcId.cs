using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvRpteVentasPorProductoPorCategoriaNcId
    {
        public int? IdNotaCredito { get; set; }
        public string? NroNotaCredito { get; set; }
        public int Pkid { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public int? Idproducto { get; set; }
    }
}
