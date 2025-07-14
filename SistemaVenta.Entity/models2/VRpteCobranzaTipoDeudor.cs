using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VRpteCobranzaTipoDeudor
    {
        public string DocCobrarPagarTipoDeudorAcre { get; set; } = null!;
        public string DocCobrarPagarCodDeudorAcre { get; set; } = null!;
        public string DocCobrarPagarDeudorAcre { get; set; } = null!;
        public DateTime DocCajaFecha { get; set; }
        public string DocCajaTipoCpCaja { get; set; } = null!;
        public string DocCajaDocCaja { get; set; } = null!;
        public decimal? DocCajaTotalSoles { get; set; }
        public decimal? DocCajaTotalDolares { get; set; }
        public string DocCobrarTipoCobrar { get; set; } = null!;
        public string DocCobrarDocCobrar { get; set; } = null!;
        public decimal? DocCobrarTotalSoles { get; set; }
        public decimal? DocCobrarTotalDolares { get; set; }
        public decimal? DocCobrarAmortizaSoles { get; set; }
        public decimal? DocCobrarAmortizaDolares { get; set; }
        public int? DocCobrarDiasVencido { get; set; }
        public int MovSaldo { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
    }
}
