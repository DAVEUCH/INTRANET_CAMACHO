using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemsConsolidadoOrdenesCompra
    {
        public int Pkid { get; set; }
        public int IdordenCompra { get; set; }
        public string IdconsolidadoOrdenCompra { get; set; } = null!;

        public virtual ConsolidadoOrdenesCompra IdconsolidadoOrdenCompraNavigation { get; set; } = null!;
    }
}
