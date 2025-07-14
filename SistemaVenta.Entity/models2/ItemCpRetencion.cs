using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpRetencion
    {
        public int Pkid { get; set; }
        public decimal MontoPago { get; set; }

        public virtual ItemCpCaja Pk { get; set; } = null!;
    }
}
