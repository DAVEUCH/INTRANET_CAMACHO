using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SolicitudCompra
    {
        public int Pkid { get; set; }
        public string EstadoAprobacion { get; set; } = null!;
        public int IdcpInventario { get; set; }
        public bool RequiereAprobacion { get; set; }

        public virtual Cp Pk { get; set; } = null!;
    }
}
