using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ComisionCuotaVentum
    {
        public int Pkid { get; set; }
        public int? IdAgrupacionCuotaVenta { get; set; }
        public int? CabIdComisionCuota { get; set; }

        public virtual CabComisionCuotum? CabIdComisionCuotaNavigation { get; set; }
    }
}
