using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVoucherContableConCentrodeCostosyTransSum1
    {
        public string Año { get; set; } = null!;
        public string Mes { get; set; } = null!;
        public string CodCc { get; set; } = null!;
        public string CentroCostoPadre { get; set; } = null!;
        public string CentroCostoHijo { get; set; } = null!;
        public string? Costo { get; set; }
        public string? Rubro { get; set; }
        public string? Cuenta { get; set; }
        public string? CuentaContableDescripcion { get; set; }
        public string CtaT1 { get; set; } = null!;
        public string CtaT2 { get; set; } = null!;
        public decimal? MontoCtaT1 { get; set; }
        public decimal? MontoCtaT2 { get; set; }
    }
}
