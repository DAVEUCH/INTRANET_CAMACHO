using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalProductoAlmacenLoteA3
    {
        public int Idproducto { get; set; }
        public int Idalmacen { get; set; }
        public int IdloteFabricacion { get; set; }
        public int StockFisico { get; set; }
        public int? CantidadFisicoFecha { get; set; }
        public int StockPorEntregar { get; set; }
        public int? CantidadPorEntregarFecha { get; set; }
        public int StockPorRecibir { get; set; }
        public int? CantidadPorRecibirFecha { get; set; }
    }
}
