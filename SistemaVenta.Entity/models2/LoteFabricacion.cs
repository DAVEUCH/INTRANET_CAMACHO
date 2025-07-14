using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class LoteFabricacion
    {
        public LoteFabricacion()
        {
            ProductoAlmacenLotes = new HashSet<ProductoAlmacenLote>();
        }

        public int Pkid { get; set; }
        public int Idproducto { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Activo { get; set; }

        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
        public virtual ICollection<ProductoAlmacenLote> ProductoAlmacenLotes { get; set; }
    }
}
