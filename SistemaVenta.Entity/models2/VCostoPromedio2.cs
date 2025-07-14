using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCostoPromedio2
    {
        public DateTime Fecha { get; set; }
        public string Movimiento { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public decimal? ValorVenta { get; set; }
        public int Idproducto { get; set; }
    }
}
