using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoNotasCreditoNess
    {
        public int Pkid { get; set; }
        public string NumeroNotaCredito { get; set; } = null!;
        public DateTime FechaComprobante { get; set; }
        public string? Cliente { get; set; }
        public string? ClienteDocumento { get; set; }
        public string? Vendedor { get; set; }
        public string? DireccionCliente { get; set; }
        public string? DireccionCliente2 { get; set; }
        public string? NumFactura { get; set; }
        public string? NumBoleta { get; set; }
        public string? Fechadocfactu { get; set; }
        public string? ItemCantidad { get; set; }
        public string? ItemCodigoProducto { get; set; }
        public string? ItemDescripcionResumidaProducto { get; set; }
        public string? ItemDescripcionProducto { get; set; }
        public decimal ItemPrecioUnitario { get; set; }
        public decimal? ItemTotal { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal? Igv { get; set; }
        public decimal Total { get; set; }
        public string? TotalLetras { get; set; }
        public int Moneda { get; set; }
    }
}
