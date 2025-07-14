using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemGastoImportacion2
    {
        public int Pkid { get; set; }
        public int IdcpImportacion2 { get; set; }
        public int IddocCobrarPagar { get; set; }
        public decimal GastoImportacion { get; set; }
        public decimal TipoCambio { get; set; }
        public string CriterioProrrateo { get; set; } = null!;

        public virtual CpImportacion2 IdcpImportacion2Navigation { get; set; } = null!;
        public virtual DocCobrarPagar IddocCobrarPagarNavigation { get; set; } = null!;
    }
}
