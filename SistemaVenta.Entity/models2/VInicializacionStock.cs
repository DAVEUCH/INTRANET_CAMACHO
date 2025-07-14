using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInicializacionStock
    {
        public int Idproducto { get; set; }
        public int? StockFisico { get; set; }
        public int? StockContable { get; set; }
    }
}
