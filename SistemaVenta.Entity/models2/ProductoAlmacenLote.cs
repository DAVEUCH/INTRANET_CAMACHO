using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoAlmacenLote
    {
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int IdloteFabricacion { get; set; }
        public int StockFisico { get; set; }
        public int StockPorEntregar { get; set; }
        public int StockPorRecibir { get; set; }

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual LoteFabricacion IdloteFabricacionNavigation { get; set; } = null!;
        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
    }
}
