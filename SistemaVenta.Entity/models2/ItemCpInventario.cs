using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpInventario
    {
        public int Pkid { get; set; }
        public int BalanceFacturacion { get; set; }
        public int BalanceDevolucion { get; set; }
        public int BalanceRecepcion { get; set; }
        public int BalanceNacionalizacion { get; set; }
        public decimal CostoParalelo { get; set; }
        public int BalanceEntregaDevolucion { get; set; }
        public int BalanceSalida { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
        public virtual ItemCpActivoFijo ItemCpActivoFijo { get; set; } = null!;
    }
}
