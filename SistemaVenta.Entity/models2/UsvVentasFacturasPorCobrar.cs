using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasFacturasPorCobrar
    {
        public DateTime Fecha { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public string NumeroFactura { get; set; } = null!;
        public string? RucCliente { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Moneda { get; set; } = null!;
        public decimal TotalFactura { get; set; }
        public decimal Saldo { get; set; }
        public string Localidad { get; set; } = null!;
        public string? Telefono { get; set; }
    }
}
