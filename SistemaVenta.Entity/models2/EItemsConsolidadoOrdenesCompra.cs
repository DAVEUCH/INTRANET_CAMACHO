using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemsConsolidadoOrdenesCompra
    {
        public int ItemsId { get; set; }
        public int ItemsIdordenCompra { get; set; }
        public string IdconsolidadoOc { get; set; } = null!;
    }
}
