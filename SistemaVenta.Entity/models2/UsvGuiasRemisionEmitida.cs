using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvGuiasRemisionEmitida
    {
        public string Sucursal { get; set; } = null!;
        public string? NumeroPed { get; set; }
        public string NroGuia { get; set; } = null!;
        public DateTime FecEmiGuia { get; set; }
        public string? HoraEmiGuia { get; set; }
        public string? NroFactura { get; set; }
        public DateTime? FecEmiFactura { get; set; }
        public decimal Total { get; set; }
        public string? EstadoFacturacion { get; set; }
        public string? Responsable { get; set; }
        public string Anulado { get; set; } = null!;
        public string? Ruc { get; set; }
        public string? Cliente { get; set; }
        public string? EmpresaTransporte { get; set; }
        public string? DireccionEntrega { get; set; }
        public string NroConsolidado { get; set; } = null!;
        public string NombreVehiculo { get; set; } = null!;
    }
}
