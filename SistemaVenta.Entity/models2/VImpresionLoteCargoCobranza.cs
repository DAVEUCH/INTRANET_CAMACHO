using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImpresionLoteCargoCobranza
    {
        public string ComprobanteNumCp { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string ComprobanteTipoCpAbreviacion { get; set; } = null!;
        public string ComprobanteResponsableCodigo { get; set; } = null!;
        public string ComprobanteResponsableNombre { get; set; } = null!;
        public string CpCobrarPagarResponsableCodigo { get; set; } = null!;
        public string CpCobrarPagarResponsableNombre { get; set; } = null!;
        public string CpCobrarPagarTipoCpAbreviacion { get; set; } = null!;
        public string CpCobrarPagarNumCp { get; set; } = null!;
        public DateTime CpCobrarPagarFechaEmision { get; set; }
        public int? CpCobrarPagarDias { get; set; }
        public string CpCobrarPagarPersonaCodigo { get; set; } = null!;
        public string CpCobrarPagarPersonaNombre { get; set; } = null!;
        public string? CpCobrarPagarPersonaDocIdentidad { get; set; }
        public string CpCobrarPagarMonedaSimbolo { get; set; } = null!;
        public decimal CpCobrarPagarSaldo { get; set; }
        public decimal CpCobrarPagarClienteBalanceLineaCredito { get; set; }
        public decimal CpCobrarPagarClienteBalanceSoles { get; set; }
        public decimal CpCobrarPagarClienteBalanceDolares { get; set; }
        public string CpCobrarPagarPersonaDistrito { get; set; } = null!;
        public string CpCobrarPagarPersonaProvincia { get; set; } = null!;
        public string CpCobrarPagarPersonaDepartamento { get; set; } = null!;
    }
}
