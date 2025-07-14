using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLiinformacionDocumentoAbonoA
    {
        public int DocumentoAbonoItemId { get; set; }
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
    }
}
