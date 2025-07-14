using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VendedorCuotaVentum
    {
        public int Pkid { get; set; }
        public int IdcuotaVenta { get; set; }
        public int Idvendedor { get; set; }

        public virtual CuotaVentum IdcuotaVentaNavigation { get; set; } = null!;
        public virtual Vendedor IdvendedorNavigation { get; set; } = null!;
    }
}
