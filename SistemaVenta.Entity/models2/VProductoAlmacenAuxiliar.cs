using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VProductoAlmacenAuxiliar
    {
        public int Pkid { get; set; }
        public string Idproducto { get; set; } = null!;
        public string Idalmacen { get; set; } = null!;
        public int IdseccionAlmacen { get; set; }
        public int Capacidad { get; set; }
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public int StockPorEntregar { get; set; }
        public int StockPorRecibir { get; set; }
    }
}
