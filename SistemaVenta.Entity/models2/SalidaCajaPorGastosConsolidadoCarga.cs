using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SalidaCajaPorGastosConsolidadoCarga
    {
        public int Pkid { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int IdcpCajaSalida { get; set; }

        public virtual ConsolidadoCarga IdconsolidadoCargaNavigation { get; set; } = null!;
        public virtual Cp IdcpCajaSalidaNavigation { get; set; } = null!;
    }
}
