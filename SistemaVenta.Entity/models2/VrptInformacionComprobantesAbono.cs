using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionComprobantesAbono
    {
        public string CpAbonoTipoCpAbreviacion { get; set; } = null!;
        public string CpAbonoNumCp { get; set; } = null!;
        public DateTime CpAbonoFecha { get; set; }
        public DateTime CpAbonoFechaEmision { get; set; }
        public decimal CpAbonoCpCobrarPagarAmortizacion { get; set; }
        public int CpAbonoCpCobrarPagarId { get; set; }
        public int CpAbonoId { get; set; }
    }
}
