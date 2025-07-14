using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PrestamoConsolidadoCarga
    {
        public int Pkid { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int Idprestamo { get; set; }

        public virtual ConsolidadoCarga IdconsolidadoCargaNavigation { get; set; } = null!;
        public virtual Cp IdprestamoNavigation { get; set; } = null!;
    }
}
