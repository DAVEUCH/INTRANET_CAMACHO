using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpCompra
    {
        public int Pkid { get; set; }
        public decimal BalanceDevolucion { get; set; }
        public decimal BalanceEntregaDevolucion { get; set; }
        public decimal BalanceDescuento { get; set; }
        public decimal BalanceEntrega { get; set; }
        public decimal CostoParalelo { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
