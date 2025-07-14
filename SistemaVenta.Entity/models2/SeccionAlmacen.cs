using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SeccionAlmacen
    {
        public SeccionAlmacen()
        {
            ProductoAlmacens = new HashSet<ProductoAlmacen>();
        }

        public int Pkid { get; set; }
        public int Idalmacen { get; set; }
        public string Descripcion { get; set; } = null!;

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual ICollection<ProductoAlmacen> ProductoAlmacens { get; set; }
    }
}
