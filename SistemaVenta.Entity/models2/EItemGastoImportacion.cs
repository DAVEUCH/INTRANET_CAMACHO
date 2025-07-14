using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemGastoImportacion
    {
        public int CpImportacionGastosId { get; set; }
        public int CpImportacionIdcpImportacion { get; set; }
        public int CpImportacionGastosIddocCobrarPagar { get; set; }
        public decimal CpImportacionGastosGastoImportacion { get; set; }
        public decimal CpImportacionGastosTipoCambio { get; set; }
        public string CpImportacionGastosCriterioProrrateo { get; set; } = null!;
    }
}
