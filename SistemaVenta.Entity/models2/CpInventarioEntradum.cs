using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpInventarioEntradum
    {
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public string? EstadoFacturacion { get; set; }
        public string? EstadoDevolucion { get; set; }
        public string NumDocOrigen { get; set; } = null!;
        public string? EstadoNacionalizacion { get; set; }
        public bool Importacion { get; set; }
        public string EstadoSalida { get; set; } = null!;

        public virtual CpInventario IdcpInventarioNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
