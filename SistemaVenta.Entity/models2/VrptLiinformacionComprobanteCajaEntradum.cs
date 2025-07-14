using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptLiinformacionComprobanteCajaEntradum
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ComprobanteNumero { get; set; } = null!;
        public string ComprobanteNumeroContable { get; set; } = null!;
        public string ComprobanteNombre { get; set; } = null!;
        public string ComprobanteTipoCp { get; set; } = null!;
        public string ComprobanteConcepto { get; set; } = null!;
        public int ComprobanteSucursalId { get; set; }
        public string ComprobanteSucursal { get; set; } = null!;
        public string ComprobanteCaja { get; set; } = null!;
        public string ComprobanteResponsable { get; set; } = null!;
        public string ComprobanteObservacion { get; set; } = null!;
        public bool ComprobanteAnulado { get; set; }
        public decimal ComprobanteTotal { get; set; }
        public int ItemId { get; set; }
        public int ItemDocumentoId { get; set; }
        public string ItemDocumentoTipoCp { get; set; } = null!;
        public string ItemDocumentoNumero { get; set; } = null!;
        public string ItemDocumentoNombre { get; set; } = null!;
        public DateTime ItemDocumentoFecha { get; set; }
        public DateTime ItemDocumentoFechaEmision { get; set; }
        public bool ItemDocumentoEsMonedaBase { get; set; }
        public string ItemDocumentoMoneda { get; set; } = null!;
        public decimal ItemDocumentoTotal { get; set; }
        public decimal ItemDocumentoSaldo { get; set; }
        public decimal ItemPagoSoles { get; set; }
        public decimal ItemPagoDolares { get; set; }
        public decimal ItemAmortizacion { get; set; }
        public string ItemDocumentoTipoCpCobrarPagar { get; set; } = null!;
        public int ItemDocumentoFactorCobrarPagar { get; set; }
        public decimal? ItemPagoTipoCambio { get; set; }
        public decimal? ItemPagoSolesEfectivo { get; set; }
        public decimal? ItemPagoDolaresEfectivo { get; set; }
        public decimal? ItemPagoSolesNoEfectivo { get; set; }
        public decimal? ItemPagoDolaresNoEfectivo { get; set; }
    }
}
