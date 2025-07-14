using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VProductoAlmacenLoteStock
    {
        public int StockFisico { get; set; }
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int IdloteFabricacion { get; set; }
    }
}
