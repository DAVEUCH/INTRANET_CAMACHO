using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PruebaComision
    {
        public string? CondicionPago { get; set; }
        public int? Proveedor { get; set; }
        public int? TipoCliente { get; set; }
        public decimal? Comision { get; set; }
    }
}
