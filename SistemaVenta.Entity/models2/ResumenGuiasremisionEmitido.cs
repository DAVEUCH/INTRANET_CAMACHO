using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ResumenGuiasremisionEmitido
    {
        public string Sucursal { get; set; } = null!;
        public string NroGuia { get; set; } = null!;
        public DateTime FecEmiGuia { get; set; }
        public string? HoraEmiGuia { get; set; }
        public string? NroFactura { get; set; }
        public DateTime? FecEmiFactura { get; set; }
        public string? HoraEmiFactura { get; set; }
        public string? Ruc { get; set; }
        public string? Cliente { get; set; }
        public string Anulado { get; set; } = null!;
    }
}
