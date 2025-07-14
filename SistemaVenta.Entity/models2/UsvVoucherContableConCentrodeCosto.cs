using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVoucherContableConCentrodeCosto
    {
        public string CodCc { get; set; } = null!;
        public string CentroCostoPadre { get; set; } = null!;
        public string CentroCostoHijo { get; set; } = null!;
        public int? IdplanCuentas { get; set; }
        public int IdcentroDeCosto { get; set; }
        public string? CuentaContableDescripcion { get; set; }
        public string Año { get; set; } = null!;
        public string Mes { get; set; } = null!;
        public string? Cuenta { get; set; }
        public string CuentaContableTransferencia { get; set; } = null!;
        public decimal CargoMonedaBase { get; set; }
        public decimal AbonoMonedaBase { get; set; }
        public decimal? CargoTrans { get; set; }
        public decimal? AbonoTrans { get; set; }
    }
}
