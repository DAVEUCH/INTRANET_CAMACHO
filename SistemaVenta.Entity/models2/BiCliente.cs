using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class BiCliente
    {
        public int? ClienteId { get; set; }
        public string? ClienteNombre { get; set; }
        public string? ClienteRuc { get; set; }
        public bool? LineaCreditoActiva { get; set; }
        public decimal? LineaCredito { get; set; }
        public decimal? LineaUtilizada { get; set; }
        public decimal? LineaDisponible { get; set; }
        public DateTime? FecCompraUlt12meses { get; set; }
        public int? TransacUlt12meses { get; set; }
        public int ImpComprasUlt12meses { get; set; }
    }
}
