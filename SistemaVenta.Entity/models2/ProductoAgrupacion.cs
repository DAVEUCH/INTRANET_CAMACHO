using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoAgrupacion
    {
        public ProductoAgrupacion()
        {
            EscalaProductoAgrupacions = new HashSet<EscalaProductoAgrupacion>();
        }

        public int Pkid { get; set; }
        public int IdproductoPadre { get; set; }
        public int Idproducto { get; set; }
        public int Idunidad { get; set; }
        public decimal Cantidad { get; set; }
        public int NumeroItem { get; set; }
        public decimal? Porcentaje { get; set; }

        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
        public virtual Producto IdproductoPadreNavigation { get; set; } = null!;
        public virtual Unidad IdunidadNavigation { get; set; } = null!;
        public virtual ICollection<EscalaProductoAgrupacion> EscalaProductoAgrupacions { get; set; }
    }
}
