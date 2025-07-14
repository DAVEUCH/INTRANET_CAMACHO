using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpOrdenPago
    {
        public int Pkid { get; set; }
        public int? IdcpOrdenPago { get; set; }
        public int? IdcuentaContable { get; set; }
        public int? IddocCobrarPagar { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? Monto { get; set; }
        public decimal? MontoTipoCambio { get; set; }
        public string? Observacion { get; set; }
        public int? IdcentroCosto { get; set; }

        public virtual CentroDeCosto? IdcentroCostoNavigation { get; set; }
        public virtual CpOrdenPago? IdcpOrdenPagoNavigation { get; set; }
        public virtual CuentaContable? IdcuentaContableNavigation { get; set; }
        public virtual DocCobrarPagar? IddocCobrarPagarNavigation { get; set; }
    }
}
