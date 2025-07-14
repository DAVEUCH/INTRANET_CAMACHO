using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvDocumentoAbonosMedioPago
    {
        public int? DocumentoAbonoItemId { get; set; }
        public string? ItemPagoCajaCodigo { get; set; }
        public string? ItemPagoCajaDescripcion { get; set; }
        public string? ItemPagoMonedaDescripcion { get; set; }
        public string? ItemPagoMonedaSimbolo { get; set; }
        public bool? ItemPagoMonedaEsBase { get; set; }
        public string? ItemPagoTipoMovimiento { get; set; }
        public int? ItemPagoMedioDePagoPkid { get; set; }
        public string? ItemPagoMedioDePagoCodigo { get; set; }
        public string? ItemPagoMedioDePagoDescripcion { get; set; }
        public bool? ItemPagoMedioDePagoEsEfectivo { get; set; }
        public string ItemPagoMedioDePagoNumero { get; set; } = null!;
        public string ItemPagoMedioDePagoObservacion { get; set; } = null!;
        public decimal ItemPagoMedioDePagoTotal { get; set; }
        public DateTime ItemPagoMedioDePagoFechaPago { get; set; }
        public DateTime ItemPagoMedioDePagoFechaEmision { get; set; }
        public string ItemPagoMedioDePagoBancoOperador { get; set; } = null!;
        public string? ItemPagoMedioDePagoCajaActualCodigo { get; set; }
        public string? ItemPagoMedioDePagoCajaActualNombre { get; set; }
        public string ItemPagoMedioDePagoEstado { get; set; } = null!;
        public decimal? ItemPagoPago { get; set; }
        public decimal? ItemPagoTipoCambio { get; set; }
        public decimal? ItemPagoAmortizacion { get; set; }
    }
}
