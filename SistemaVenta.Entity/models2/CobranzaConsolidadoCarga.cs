using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CobranzaConsolidadoCarga
    {
        public int Pkid { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int Idcobranza { get; set; }

        public virtual CpCajaEntradum IdcobranzaNavigation { get; set; } = null!;
        public virtual ConsolidadoCarga IdconsolidadoCargaNavigation { get; set; } = null!;
    }
}
