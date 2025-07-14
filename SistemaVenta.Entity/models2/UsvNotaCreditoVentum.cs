using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvNotaCreditoVentum
    {
        public DateTime FechaEmision { get; set; }
        public string NroNotaCred { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public string? Cliente { get; set; }
        public string? Responsable { get; set; }
        public string MonedaNotaCred { get; set; } = null!;
        public decimal TotalNotaCred { get; set; }
        public string? NroDocRelacionado { get; set; }
        public DateTime? FechaDocRelacionado { get; set; }
        public decimal? ImporteDocRelacionado { get; set; }
        public string Anulado { get; set; } = null!;
    }
}
