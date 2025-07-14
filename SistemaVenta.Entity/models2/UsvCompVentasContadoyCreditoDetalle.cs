using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCompVentasContadoyCreditoDetalle
    {
        public string? ItemPagoTipoMovimiento { get; set; }
        public int DocCargoId { get; set; }
        public string DocCargoTipoCpAbreviacion { get; set; } = null!;
        public string DocCargoNumero { get; set; } = null!;
        public DateTime DocCargoFecha { get; set; }
        public DateTime DocCargoFechaEmision { get; set; }
        public DateTime DocCargoFechaVencimiento { get; set; }
        public int? DocCargoSucursalId { get; set; }
        public string? DocCargoSucursalNombre { get; set; }
        public string DocCargoMonedaSimbolo { get; set; } = null!;
        public decimal DocCargoSaldo { get; set; }
        public decimal? DocCargoSaldoASoles { get; set; }
        public bool DocCargoEsCredito { get; set; }
        public string? DocCargoPersonaDocIdentidad { get; set; }
        public string DocCargoPersonaNombre { get; set; } = null!;
        public decimal DocCargoTotal { get; set; }
        public decimal? DocCargoTotalASoles { get; set; }
        public int? ItemPagoMedioDePagoPkid { get; set; }
        public string? ItemPagoMedioDePagoCodigo { get; set; }
        public string? ItemPagoMedioDePagoDescripcion { get; set; }
        public decimal? ItemPagoTipoCambio { get; set; }
        public string? ItemPagoMonedaSimbolo { get; set; }
        public decimal? ItemPagoAmortizacion { get; set; }
        public decimal? ItemPagoMedioDePagoTotal { get; set; }
    }
}
