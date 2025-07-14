using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ActivoFijoCpActivoFijoEntradum
    {
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public string EstadoDevolucion { get; set; } = null!;
        public string NumDocOrigen { get; set; } = null!;
        public string? EstadoNacionalizacion { get; set; }
        public bool Importacion { get; set; }

        public virtual CpInventario IdcpInventarioNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
