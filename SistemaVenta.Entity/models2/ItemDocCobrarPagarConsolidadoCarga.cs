using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemDocCobrarPagarConsolidadoCarga
    {
        public int Pkid { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int IddocCobrarPagar { get; set; }

        public virtual ConsolidadoCarga IdconsolidadoCargaNavigation { get; set; } = null!;
        public virtual DocCobrarPagar IddocCobrarPagarNavigation { get; set; } = null!;
    }
}
