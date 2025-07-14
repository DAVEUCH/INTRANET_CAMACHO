using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvNotaCreditoCompraDetallado
    {
        public string? NombreCptoOperacion { get; set; }
        public string NombreSucursal { get; set; } = null!;
        public string NroNotaCredito { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Proveedor { get; set; }
        public string? CodigoProducto { get; set; }
        public string? Aplicacion { get; set; }
        public string DescripcionProducto { get; set; } = null!;
        public decimal CantDeDevolucion { get; set; }
        public decimal Monto { get; set; }
        public decimal? Saldo { get; set; }
        public string Observacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string? ComprobanteCompra { get; set; }
        public decimal? MontoComprobanteCompra { get; set; }
    }
}
