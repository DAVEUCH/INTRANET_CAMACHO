using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabVentasPorClientesUlt12mese
    {
        public int? ClienteId { get; set; }
        public string? ClienteNombre { get; set; }
        public DateTime? FecCompraUlt12meses { get; set; }
        public int? TransacUlt12meses { get; set; }
        public int ImpComprasUlt12meses { get; set; }
    }
}
