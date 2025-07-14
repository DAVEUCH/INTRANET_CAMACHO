using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasTipoMedioPago
    {
        public string DocCargoTipoCpAbreviacion { get; set; } = null!;
        public string DocCargoNumero { get; set; } = null!;
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public DateTime DocCargoFecha { get; set; }
        public DateTime DocCargoFechaEmision { get; set; }
        public DateTime DocCargoFechaVencimiento { get; set; }
        public string? ItemPagoMonedaSimbolo { get; set; }
        public string? DocCargoId { get; set; }
        public string DocCargoPersonaNombre { get; set; } = null!;
        public string? DocCargoPersonaDocIdentidad { get; set; }
        public int? DocCargoSucursalId { get; set; }
        public string? DocCargoSucursalNombre { get; set; }
        public decimal DocCargoSaldo { get; set; }
        public decimal? DocCargoSaldoASoles { get; set; }
        public decimal? DocCargoTotal { get; set; }
        public decimal? DocCargoTotalASoles { get; set; }
        public bool DocCargoEsCredito { get; set; }
        public int? ItemPagoMedioDePagoPkid { get; set; }
        public string? ItemPagoMedioDePagoCodigo { get; set; }
        public string? ItemPagoMedioDePagoDescripcion { get; set; }
        public decimal? ItemPagoTipoCambio { get; set; }
        public decimal? ItemPagoMedioDePagoTotal { get; set; }
        public decimal? ItemPagoMedioDePagoTotalSol { get; set; }
        public decimal? ItemPagoMedioDePagoTotalDol { get; set; }
        public decimal? ItemPagoMedioDePagoTotalASoles { get; set; }
    }
}
