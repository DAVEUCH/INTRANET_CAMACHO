using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCuotaVentum
    {
        public int ItemsId { get; set; }
        public int IdcuotaVenta { get; set; }
        public int ItemsIdvendedor { get; set; }
        public int ItemsIdagrupacionCuotaVenta { get; set; }
        public decimal ItemsMontoCuota { get; set; }
    }
}
