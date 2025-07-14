using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvNotaCreditoPendEntAlmacen
    {
        public string TipoCp { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string? PersonaNombre { get; set; }
        public string Simbolo { get; set; } = null!;
        public decimal Total { get; set; }
        public decimal? Saldo { get; set; }
        public string? CpFactura { get; set; }
        public string? CpentAlmacen { get; set; }
    }
}
