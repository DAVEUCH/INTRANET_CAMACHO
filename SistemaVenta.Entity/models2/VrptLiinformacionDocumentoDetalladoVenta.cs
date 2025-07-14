using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLiinformacionDocumentoDetalladoVenta
    {
        public int DocumentoId { get; set; }
        public int DocumentoCargoId { get; set; }
        public int DocumentoCargoTipoCpId { get; set; }
        public string DocumentoCargoTipoCpAbreviacion { get; set; } = null!;
        public int DocumentoCargoOrigenDestinoId { get; set; }
        public string DocumentoCargoOrigenDestinoCodigo { get; set; } = null!;
        public string DocumentoCargoOrigenDestinoNombre { get; set; } = null!;
        public string? DocumentoCargoPersonaDocIdentidad { get; set; }
        public DateTime DocumentoCargoFecha { get; set; }
        public DateTime DocumentoCargoFechaEmision { get; set; }
        public DateTime DocumentoCargoFechaVencimiento { get; set; }
        public string DocumentoCargoNumero { get; set; } = null!;
        public string DocumentoCargoObservacion { get; set; } = null!;
        public bool DocumentoCargoAnulado { get; set; }
        public decimal DocumentoCargoSaldo { get; set; }
        public decimal? DocumentoCargoSaldoASoles { get; set; }
        public decimal DocumentoCargoTotal { get; set; }
        public decimal? DocumentoCargoTotalASoles { get; set; }
        public string DocumentoCargoTipoCobrarPagar { get; set; } = null!;
        public bool DocumentoCargoEsCredito { get; set; }
        public int DocumentoCargoMonedaId { get; set; }
        public string DocumentoCargoMonedaDescripcion { get; set; } = null!;
        public string DocumentoCargoMonedaSimbolo { get; set; } = null!;
        public bool DocumentoCargoMonedaEsBase { get; set; }
        public int? DocumentoCargoSucursalId { get; set; }
        public string? DocumentoCargoSucursalNombre { get; set; }
        public int DocumentoCargoModalidadCreditoId { get; set; }
        public string DocumentoCargoModalidadCreditoCodigo { get; set; } = null!;
        public string DocumentoCargoModalidadCreditoDescripcion { get; set; } = null!;
        public int DocumentoCargoModalidadCreditoDiasCredito { get; set; }
        public int DocumentoCargoEsLetra { get; set; }
        public int DocumentoCargoLetraBancoId { get; set; }
        public string DocumentoCargoLetraBancoNombre { get; set; } = null!;
        public int DocumentoCargoLetraEstadoId { get; set; }
        public string DocumentoCargoLetraEstadoDescripcion { get; set; } = null!;
        public bool DocumentoCargoLetraEnBanco { get; set; }
        public string DocumentoCargoLetraNumeroUnicoEnBanco { get; set; } = null!;
        public int? DocumentoAbonoItemId { get; set; }
        public int? DocumentoAbonoId { get; set; }
        public string? DocumentoAbonoTipoCp { get; set; }
        public DateTime? DocumentoAbonoFecha { get; set; }
        public DateTime? DocumentoAbonoFechaEmision { get; set; }
        public string? DocumentoAbonoNumero { get; set; }
        public string? DocumentoAbonoObservacion { get; set; }
        public string? DocumentoAbonoNombre { get; set; }
        public int? DocumentoAbonoMonedaId { get; set; }
        public string? DocumentoAbonoMonedaDescripcion { get; set; }
        public string? DocumentoAbonoMonedaSimbolo { get; set; }
        public bool? DocumentoAbonoMonedaEsBase { get; set; }
        public string? DocumentoAbonoTipo { get; set; }
        public string? ItemPagoCajaCodigo { get; set; }
        public string? ItemPagoCajaDescripcion { get; set; }
        public string? ItemPagoMonedaDescripcion { get; set; }
        public string? ItemPagoMonedaSimbolo { get; set; }
        public bool? ItemPagoMonedaEsBase { get; set; }
        public string? ItemPagoTipoMovimiento { get; set; }
        public int ItemPagoMedioDePagoPkid { get; set; }
        public string ItemPagoMedioDePagoCodigo { get; set; } = null!;
        public string? ItemPagoMedioDePagoDescripcion { get; set; }
        public int? ItemPagoMedioDePagoEsEfectivo { get; set; }
        public string? ItemPagoMedioDePagoNumero { get; set; }
        public string? ItemPagoMedioDePagoObservacion { get; set; }
        public decimal? ItemPagoMedioDePagoTotal { get; set; }
        public DateTime? ItemPagoMedioDePagoFechaPago { get; set; }
        public DateTime? ItemPagoMedioDePagoFechaEmision { get; set; }
        public string? ItemPagoMedioDePagoBancoOperador { get; set; }
        public string? ItemPagoMedioDePagoCajaActualCodigo { get; set; }
        public string? ItemPagoMedioDePagoCajaActualNombre { get; set; }
        public string? ItemPagoMedioDePagoEstado { get; set; }
        public decimal? ItemPagoPago { get; set; }
        public decimal? ItemPagoTipoCambio { get; set; }
        public decimal ItemPagoAmortizacion { get; set; }
    }
}
