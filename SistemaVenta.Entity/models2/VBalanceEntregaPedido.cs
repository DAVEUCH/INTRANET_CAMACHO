using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VBalanceEntregaPedido
    {
        public int Pkid { get; set; }
        public int Iditem { get; set; }
        public decimal BalanceEntrega { get; set; }
        public int? BalanceEntrega2 { get; set; }
        public string NumCp { get; set; } = null!;
    }
}
