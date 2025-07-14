using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ImpuestoProductoServicio
    {
        public int IdproductoServicio { get; set; }
        public int Idimpuesto { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        public bool Inafecto { get; set; }

        public virtual Impuesto IdimpuestoNavigation { get; set; } = null!;
        public virtual ProductoServicio IdproductoServicioNavigation { get; set; } = null!;
    }
}
