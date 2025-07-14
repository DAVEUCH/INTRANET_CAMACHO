using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprasConBoleta
    {
        public string Sucursal { get; set; } = null!;
        public string TipoComprobante { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public string? Ruc { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Nrus { get; set; } = null!;
        public string Simbolo { get; set; } = null!;
        public decimal Total { get; set; }
        public string? Responsable { get; set; }
        public string Observacion { get; set; } = null!;
        public string NumCpContable { get; set; } = null!;
    }
}
