using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvNotaCreditoVentaDetallado
    {
        public string? CodigoCptoOperacion { get; set; }
        public string? NombreCptoOperacion { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Cliente { get; set; }
        public string? Codigo { get; set; }
        public string? Aplicacion { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal CantDeDevolucion { get; set; }
        public decimal Monto { get; set; }
        public string Observacion { get; set; } = null!;
        public string? MotivoDevolucion { get; set; }
        public string? Vendedor { get; set; }
        public string Estado { get; set; } = null!;
        public string? ComprobanteVenta { get; set; }
        public decimal? MontoComprobanteVenta { get; set; }
        public string NombreSucursal { get; set; } = null!;
        public int Idsucursal { get; set; }
    }
}
