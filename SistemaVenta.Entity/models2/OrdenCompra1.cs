using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class OrdenCompra1
    {
        public int Pkid { get; set; }
        public DateTime? FechaEmbarque { get; set; }
        public DateTime? FechaLlegada { get; set; }
        public string? IngresoCargaOld { get; set; }
        public DateTime IngresoCarga { get; set; }

        public virtual OrdenCompra Pk { get; set; } = null!;
    }
}
