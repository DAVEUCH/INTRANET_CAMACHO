using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GastoConsolidadoCarga
    {
        public int Pkid { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int Idgasto { get; set; }

        public virtual ConsolidadoCarga IdconsolidadoCargaNavigation { get; set; } = null!;
        public virtual Cp IdgastoNavigation { get; set; } = null!;
    }
}
