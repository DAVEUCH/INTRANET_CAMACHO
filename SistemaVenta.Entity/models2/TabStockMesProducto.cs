using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabStockMesProducto
    {
        public int? Idproducto { get; set; }
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? StockIni { get; set; }
        public int? StockEnt { get; set; }
        public int? StockFin { get; set; }
    }
}
