using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImpresionCpSalida2
    {
        public int Pkid { get; set; }
        public string NumeroCp { get; set; } = null!;
        public string? NombreCliente { get; set; }
        public string? DocumentoCliente { get; set; }
        public string? DireccionCliente { get; set; }
        public string? DireccionPartida { get; set; }
        public string? DireccionLlegada { get; set; }
        public string? NombreTransporte { get; set; }
        public string? DocumentoTransporte { get; set; }
        public string DirecionTransporte { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public DateTime Fecha { get; set; }
        public string MotivoTraslado { get; set; } = null!;
        public string? NumeroFactura { get; set; }
        public DateTime? FechaEmisionFactura { get; set; }
        public decimal CantidadProducto { get; set; }
        public string UnidadMedida { get; set; } = null!;
        public string CodigoProducto { get; set; } = null!;
        public string DescripcionResumidaProducto { get; set; } = null!;
        public string? DescripcionProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal? TotalProducto { get; set; }
        public decimal? TotalCp { get; set; }
        public int Moneda { get; set; }
    }
}
