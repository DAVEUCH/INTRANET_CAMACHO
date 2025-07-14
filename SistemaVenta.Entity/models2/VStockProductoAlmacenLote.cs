using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VStockProductoAlmacenLote
    {
        public int Idproducto { get; set; }
        public int Idalmacen { get; set; }
        public int IdloteFabricacion { get; set; }
        public int StockFisico { get; set; }
        public int StockPorEntregar { get; set; }
        public int StockPorRecibir { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Activo { get; set; }
    }
}
