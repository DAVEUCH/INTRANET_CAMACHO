using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProdNeg
    {
        public int Idproducto { get; set; }
        public decimal? StockContable { get; set; }
        public decimal? StockFisico { get; set; }
        public decimal? StockPorEntregar { get; set; }
        public decimal? StockPorRecibir { get; set; }
    }
}
