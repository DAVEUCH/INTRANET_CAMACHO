using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalProducto
    {
        public int Idproducto { get; set; }
        public decimal Stock { get; set; }
        public int? StockFisicoAlmacen { get; set; }
        public decimal StockContable { get; set; }
        public int? StockContableAlmacen { get; set; }
        public decimal StockPorRecibir { get; set; }
        public int? StockPorEntregarAlmacen { get; set; }
        public decimal StockPorEntregar { get; set; }
        public int? StockPorRecibirAlmacen { get; set; }
    }
}
