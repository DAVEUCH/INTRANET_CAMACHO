using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VistaNessResumenVentum
    {
        public DateTime? Fecha { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal? TotalBoleta { get; set; }
        public decimal? TotalBoletaIgv { get; set; }
        public decimal? TotalFactura { get; set; }
        public decimal? TotalFacturaIgv { get; set; }
        public decimal? TotalCargo { get; set; }
        public decimal? TotalCargoIgv { get; set; }
        public decimal? TotalAbono { get; set; }
        public decimal? TotalAbonoIgv { get; set; }
        public string TipoCliente { get; set; } = null!;
    }
}
