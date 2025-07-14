using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCostoPromedio
    {
        public DateTime Fecha { get; set; }
        public string Movimiento { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal? ValorVenta { get; set; }
        public int Idproducto { get; set; }
        public string? Idcp { get; set; }
        public string? Iditem { get; set; }
    }
}
