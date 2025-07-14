using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCuotaVentum
    {
        public int Pkid { get; set; }
        public int? IdcuotaVenta { get; set; }
        public int? Idvendedor { get; set; }
        public int? IdagrupacionCuotaVenta { get; set; }
        public decimal? MontoCuota { get; set; }

        public virtual CuotaVentum? IdcuotaVentaNavigation { get; set; }
    }
}
