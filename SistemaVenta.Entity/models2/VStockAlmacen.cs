using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VStockAlmacen
    {
        public int Idsucursal { get; set; }
        public int? Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int? StockFisico { get; set; }
        public int? StockContable { get; set; }
        public int? StockPorRecibir { get; set; }
        public int? StockPorEntregar { get; set; }
    }
}
