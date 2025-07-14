using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemNotaCredito
    {
        public int Pkid { get; set; }
        public decimal BalanceEntregaDevolucion { get; set; }
        public int Idbonificacion { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
