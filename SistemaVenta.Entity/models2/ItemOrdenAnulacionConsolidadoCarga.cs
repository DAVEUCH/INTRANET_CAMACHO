using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemOrdenAnulacionConsolidadoCarga
    {
        public int Pkid { get; set; }
        public int IdordenAnulacion { get; set; }
        public int IdconsolidadoCarga { get; set; }

        public virtual ConsolidadoCarga IdconsolidadoCargaNavigation { get; set; } = null!;
        public virtual OrdenAnulacion IdordenAnulacionNavigation { get; set; } = null!;
    }
}
