using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NotaCredito
    {
        public NotaCredito()
        {
            ItemNotaCreditoConsolidadoCargas = new HashSet<ItemNotaCreditoConsolidadoCarga>();
        }

        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public string DocIdentidad { get; set; } = null!;
        public string? EstadoEntregaDevolucion { get; set; }
        public string Direccion { get; set; } = null!;
        public string DireccionEntrega { get; set; } = null!;

        public virtual Cp Pk { get; set; } = null!;
        public virtual ICollection<ItemNotaCreditoConsolidadoCarga> ItemNotaCreditoConsolidadoCargas { get; set; }
    }
}
