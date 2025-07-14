using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoProductoServicio
    {
        public TipoProductoServicio()
        {
            ProductoServicios = new HashSet<ProductoServicio>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<ProductoServicio> ProductoServicios { get; set; }
    }
}
