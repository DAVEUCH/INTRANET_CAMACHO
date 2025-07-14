using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class BiClientesRfm
    {
        public double? ClienteId { get; set; }
        public string? ClienteNombre { get; set; }
        public string? ClienteRuc { get; set; }
        public double? LineaCreditoActiva { get; set; }
        public double? LineaCredito { get; set; }
        public double? LineaUtilizada { get; set; }
        public double? LineaDisponible { get; set; }
        public DateTime? FecCompraUlt12meses { get; set; }
        public double? TransacUlt12meses { get; set; }
        public double? ImpComprasUlt12meses { get; set; }
        public double? PuntuaciónActualidad { get; set; }
        public double? PuntuaciónFrecuencia { get; set; }
        public double? PuntuaciónMonetaria { get; set; }
        public double? PuntuaciónRfm { get; set; }
    }
}
