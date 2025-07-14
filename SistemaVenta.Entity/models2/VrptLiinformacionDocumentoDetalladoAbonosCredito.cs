using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLiinformacionDocumentoDetalladoAbonosCredito
    {
        public string DocumentoCargoTipoCpAbreviacion { get; set; } = null!;
        public string DocumentoCargoOrigenDestinoCodigo { get; set; } = null!;
        public string DocumentoCargoOrigenDestinoNombre { get; set; } = null!;
        public string? DocumentoCargoPersonaDocIdentidad { get; set; }
        public DateTime DocumentoCargoFecha { get; set; }
        public DateTime DocumentoCargoFechaEmision { get; set; }
        public DateTime DocumentoCargoFechaVencimiento { get; set; }
        public string DocumentoCargoNumero { get; set; } = null!;
        public decimal DocumentoCargoSaldo { get; set; }
        public decimal DocumentoCargoTotal { get; set; }
        public string DocumentoCargoTipoCobrarPagar { get; set; } = null!;
        public bool DocumentoCargoEsCredito { get; set; }
        public string DocumentoCargoMonedaSimbolo { get; set; } = null!;
        public string DocumentoCargoSucursalNombre { get; set; } = null!;
        public int DocumentoCargoModalidadCreditoDiasCredito { get; set; }
        public string DocumentoAbonoTipoCp { get; set; } = null!;
        public DateTime DocumentoAbonoFecha { get; set; }
        public DateTime DocumentoAbonoFechaEmision { get; set; }
        public string DocumentoAbonoNumero { get; set; } = null!;
        public string? DocumentoAbonoNombre { get; set; }
        public string DocumentoAbonoMonedaDescripcion { get; set; } = null!;
        public string DocumentoAbonoMonedaSimbolo { get; set; } = null!;
        public string DocumentoAbonoTipo { get; set; } = null!;
        public string ItemPagoCajaCodigo { get; set; } = null!;
        public string ItemPagoMonedaSimbolo { get; set; } = null!;
        public string ItemPagoTipoMovimiento { get; set; } = null!;
        public int ItemPagoMedioDePagoPkid { get; set; }
        public string ItemPagoMedioDePagoCodigo { get; set; } = null!;
        public string ItemPagoMedioDePagoDescripcion { get; set; } = null!;
        public int ItemPagoMedioDePagoEsEfectivo { get; set; }
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
    }
}
