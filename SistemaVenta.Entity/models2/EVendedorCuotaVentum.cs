using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVendedorCuotaVentum
    {
        public int VendedoresId { get; set; }
        public int IdcuotaVenta { get; set; }
        public int VendedoresIdvendedor { get; set; }
    }
}
