using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemOrdenTransformacion
    {
        public int Pkid { get; set; }
        public decimal BalanceEntrega { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
