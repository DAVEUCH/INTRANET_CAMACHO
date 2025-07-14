using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Cotizacion3
    {
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public string EstadoAprobacion { get; set; } = null!;
        public string? EstadoFacturacion { get; set; }

        public virtual Cp Pk { get; set; } = null!;
    }
}
