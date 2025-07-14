using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCompVentasCredito
    {
        public int DocumentoId { get; set; }
        public string DocCargoTipoCpAbreviacion { get; set; } = null!;
        public string DocCargoNumero { get; set; } = null!;
        public DateTime DocCargoFecha { get; set; }
        public DateTime DocCargoFechaEmision { get; set; }
        public int DocCargoPersonaId { get; set; }
        public string DocCargoPersonaCodigo { get; set; } = null!;
        public string DocCargoPersonaNombre { get; set; } = null!;
        public string? DocCargoPersonaDocIdentidad { get; set; }
        public int DocCargoMonedaId { get; set; }
        public string DocCargoMonedaDescripcion { get; set; } = null!;
        public string DocCargoMonedaSimbolo { get; set; } = null!;
        public bool DocCargoMonedaEsBase { get; set; }
        public int DocCargoId { get; set; }
        public DateTime DocCargoFechaVencimiento { get; set; }
        public decimal DocCargoSaldo { get; set; }
        public decimal? DocCargoSaldoASoles { get; set; }
        public decimal DocCargoTotal { get; set; }
        public decimal? DocCargoTotalASoles { get; set; }
        public string DocCargoTipoCobrarPagar { get; set; } = null!;
        public bool DocCargoEsCredito { get; set; }
        public int? DocCargoSucursalId { get; set; }
        public string? DocCargoSucursalNombre { get; set; }
        public int DocCargoModalidadCreditoId { get; set; }
        public string DocCargoModalidadCreditoCodigo { get; set; } = null!;
        public string DocCargoModalidadCreditoDescripcion { get; set; } = null!;
        public int DocCargoModalidadCreditoDiasCredito { get; set; }
    }
}
