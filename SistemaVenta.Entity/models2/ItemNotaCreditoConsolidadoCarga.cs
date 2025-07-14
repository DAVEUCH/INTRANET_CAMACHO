using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemNotaCreditoConsolidadoCarga
    {
        public int Pkid { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int IdnotaCredito { get; set; }

        public virtual ConsolidadoCarga IdconsolidadoCargaNavigation { get; set; } = null!;
        public virtual NotaCredito IdnotaCreditoNavigation { get; set; } = null!;
    }
}
