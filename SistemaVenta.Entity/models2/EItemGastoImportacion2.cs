using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemGastoImportacion2
    {
        public int CpImportacion2GastosId { get; set; }
        public int CpImportacion2IdcpImportacion2 { get; set; }
        public int CpImportacion2GastosIddocCobrarPagar { get; set; }
        public decimal CpImportacion2GastosGastoImportacion { get; set; }
        public decimal CpImportacion2GastosTipoCambio { get; set; }
        public string CpImportacion2GastosCriterioProrrateo { get; set; } = null!;
    }
}
