using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EStockAlmacen
    {
        public int StockAlmacenesIdalmacen { get; set; }
        public int Idproducto { get; set; }
        public decimal StockAlmacenesStockFisico { get; set; }
        public decimal StockAlmacenesStockContable { get; set; }
        public decimal StockAlmacenesStockPorRecibir { get; set; }
        public decimal StockAlmacenesStockPorEntregar { get; set; }
    }
}
