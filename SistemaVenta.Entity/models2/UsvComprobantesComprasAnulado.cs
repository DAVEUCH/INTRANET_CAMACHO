using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprobantesComprasAnulado
    {
        public string? Sucursal { get; set; }
        public string? TipoDoc { get; set; }
        public string NumeroDoc { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string? Proveedor { get; set; }
        public string? Moneda { get; set; }
        public decimal Total { get; set; }
        public string? Responsable { get; set; }
        public string Estado { get; set; } = null!;
    }
}
