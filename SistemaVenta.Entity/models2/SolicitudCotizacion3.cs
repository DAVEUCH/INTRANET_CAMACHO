using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SolicitudCotizacion3
    {
        public int Pkid { get; set; }
        public string EstadoAprobacion { get; set; } = null!;
        public int IdcpInventario { get; set; }
        public bool RequiereAprobacion { get; set; }
        public string? EstadoRemision { get; set; }
        public DateTime? FechaAprobacion { get; set; }

        public virtual Cp Pk { get; set; } = null!;
    }
}
