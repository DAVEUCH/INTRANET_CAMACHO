using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DistribucionCostosProducto
    {
        public int Pkid { get; set; }
        public int Idproducto { get; set; }
        public int IddistribucionCosto { get; set; }

        public virtual DistribucionCosto IddistribucionCostoNavigation { get; set; } = null!;
        public virtual Producto IdproductoNavigation { get; set; } = null!;
    }
}
