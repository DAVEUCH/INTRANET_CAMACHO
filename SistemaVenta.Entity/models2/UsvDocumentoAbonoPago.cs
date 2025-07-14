using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvDocumentoAbonoPago
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
        public decimal DocumentoCargoTotal { get; set; }
        public string DocumentoCargoTipoCobrarPagar { get; set; } = null!;
        public bool DocumentoCargoEsCredito { get; set; }
        public int DocumentoCargoMonedaId { get; set; }
        public string DocumentoCargoMonedaDescripcion { get; set; } = null!;
        public string DocumentoCargoMonedaSimbolo { get; set; } = null!;
        public bool DocumentoCargoMonedaEsBase { get; set; }
        public int DocumentoCargoSucursalId { get; set; }
        public string DocumentoCargoSucursalNombre { get; set; } = null!;
        public int DocumentoCargoModalidadCreditoId { get; set; }
        public string DocumentoCargoModalidadCreditoCodigo { get; set; } = null!;
        public string DocumentoCargoModalidadCreditoDescripcion { get; set; } = null!;
        public int DocumentoCargoModalidadCreditoDiasCredito { get; set; }
        public bool? DocumentoCargoEsLetra { get; set; }
        public int DocumentoCargoLetraBancoId { get; set; }
        public string DocumentoCargoLetraBancoNombre { get; set; } = null!;
        public int DocumentoCargoLetraEstadoId { get; set; }
        public string DocumentoCargoLetraEstadoDescripcion { get; set; } = null!;
        public bool DocumentoCargoLetraEnBanco { get; set; }
        public string DocumentoCargoLetraNumeroUnicoEnBanco { get; set; } = null!;
        public int DocumentoAbonoItemId { get; set; }
        public int DocumentoAbonoId { get; set; }
        public string DocumentoAbonoTipoCp { get; set; } = null!;
        public DateTime DocumentoAbonoFecha { get; set; }
        public DateTime DocumentoAbonoFechaEmision { get; set; }
        public string DocumentoAbonoNumero { get; set; } = null!;
        public string DocumentoAbonoObservacion { get; set; } = null!;
        public string? DocumentoAbonoNombre { get; set; }
        public int DocumentoAbonoMonedaId { get; set; }
        public string DocumentoAbonoMonedaDescripcion { get; set; } = null!;
        public string DocumentoAbonoMonedaSimbolo { get; set; } = null!;
        public bool DocumentoAbonoMonedaEsBase { get; set; }
        public string DocumentoAbonoTipo { get; set; } = null!;
        public string ItemPagoCajaCodigo { get; set; } = null!;
        public string ItemPagoCajaDescripcion { get; set; } = null!;
        public string ItemPagoMonedaDescripcion { get; set; } = null!;
        public string ItemPagoMonedaSimbolo { get; set; } = null!;
        public bool ItemPagoMonedaEsBase { get; set; }
        public string ItemPagoTipoMovimiento { get; set; } = null!;
        public int ItemPagoMedioDePagoPkid { get; set; }
        public string ItemPagoMedioDePagoCodigo { get; set; } = null!;
        public string ItemPagoMedioDePagoDescripcion { get; set; } = null!;
        public bool ItemPagoMedioDePagoEsEfectivo { get; set; }
        public string ItemPagoMedioDePagoNumero { get; set; } = null!;
        public string ItemPagoMedioDePagoObservacion { get; set; } = null!;
        public decimal ItemPagoMedioDePagoTotal { get; set; }
        public DateTime ItemPagoMedioDePagoFechaPago { get; set; }
        public DateTime ItemPagoMedioDePagoFechaEmision { get; set; }
        public string ItemPagoMedioDePagoBancoOperador { get; set; } = null!;
        public string ItemPagoMedioDePagoCajaActualCodigo { get; set; } = null!;
        public string ItemPagoMedioDePagoCajaActualNombre { get; set; } = null!;
        public string ItemPagoMedioDePagoEstado { get; set; } = null!;
        public decimal ItemPagoPago { get; set; }
        public decimal ItemPagoTipoCambio { get; set; }
        public decimal ItemPagoAmortizacion { get; set; }
        public string ItemLetraTipoCp { get; set; } = null!;
        public int ItemLetraFecha { get; set; }
        public int ItemLetraFechaEmision { get; set; }
        public string ItemLetraNumero { get; set; } = null!;
        public string ItemLetraObservacion { get; set; } = null!;
        public string ItemLetraNombre { get; set; } = null!;
        public int ItemLetraAnulado { get; set; }
        public string ItemLetraMonedaDescripcion { get; set; } = null!;
        public string ItemLetraMonedaSimbolo { get; set; } = null!;
        public int ItemLetraMonedaEsBase { get; set; }
        public int ItemLetraFechaVencimiento { get; set; }
        public int ItemLetraTotal { get; set; }
        public int ItemLetraSaldo { get; set; }
        public string ItemLetraTipoCobrarPagar { get; set; } = null!;
        public int ItemLetraEnBanco { get; set; }
        public string ItemLetraNumeroEnBanco { get; set; } = null!;
        public string ItemLetraBanco { get; set; } = null!;
        public string ItemLetraEstado { get; set; } = null!;
        public int ItemLetraDias { get; set; }
        public int ItemLetraPorcentaje { get; set; }
        public int ItemRetencionMontoRetencion { get; set; }
        public int ItemRetencionAmortizacion { get; set; }
        public int ItemRetencionTipoCambio { get; set; }
    }
}
