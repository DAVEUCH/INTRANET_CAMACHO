using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDistribucionCostosProducto
    {
        public int Id { get; set; }
        public int DistribucionCostosProductosId { get; set; }
        public int DistribucionCostosProductosIdproducto { get; set; }
        public int Idproducto { get; set; }
        public int IddistribucionCosto { get; set; }
    }
}
