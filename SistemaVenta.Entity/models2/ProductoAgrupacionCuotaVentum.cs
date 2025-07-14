using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoAgrupacionCuotaVentum
    {
        public int Pkid { get; set; }
        public int IdagrupacionCuotaVenta { get; set; }
        public int Idproducto { get; set; }

        public virtual AgrupacionCuotaVentum IdagrupacionCuotaVentaNavigation { get; set; } = null!;
        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
    }
}
