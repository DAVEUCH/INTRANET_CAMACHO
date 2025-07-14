using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCpOrdenPago
    {
        public int ItemCpOrdenPagoId { get; set; }
        public int? ItemCpOrdenPagoIdcuentaContable { get; set; }
        public int? ItemCpOrdenPagoIddocCobrarPagar { get; set; }
        public decimal? ItemCpOrdenPagoMonto { get; set; }
        public int? IdcpOrdenPago { get; set; }
        public decimal? ItemCpOrdenPagoMontoTipoCambio { get; set; }
        public decimal? ItemCpOrdenPagoTipoCambio { get; set; }
        public string? ItemCpOrdenPagoObservacion { get; set; }
        public int? ItemCpOrdenPagoIdcentroCosto { get; set; }
    }
}
