using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemRequerimientoMercaderium
    {
        public int Pkid { get; set; }
        public decimal BalanceEntrega { get; set; }
        public decimal BalanceRecepcion { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
