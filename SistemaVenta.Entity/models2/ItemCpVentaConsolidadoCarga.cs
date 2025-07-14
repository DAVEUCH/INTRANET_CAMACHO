using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpVentaConsolidadoCarga
    {
        public int Pkid { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int IdcpVenta { get; set; }
        public bool Entrega { get; set; }
        public DateTime FechaAceptacion { get; set; }

        public virtual ConsolidadoCarga IdconsolidadoCargaNavigation { get; set; } = null!;
        public virtual CpVentum IdcpVentaNavigation { get; set; } = null!;
    }
}
