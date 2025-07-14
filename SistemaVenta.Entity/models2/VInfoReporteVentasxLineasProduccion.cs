using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoReporteVentasxLineasProduccion
    {
        public string NumeroContable { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public string TipoComprobanteDescripcion { get; set; } = null!;
        public string? TipoComprobantePagoCodigo { get; set; }
        public string? NumeroSerie { get; set; }
        public string? Numero { get; set; }
        public string TipoDocumentoIdentidadCodigo { get; set; } = null!;
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteDocumentoIdentidad { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public decimal? SubTotal { get; set; }
        public decimal? ValorDescuento { get; set; }
        public int ValorExportacion { get; set; }
        public decimal? ValorAfecto { get; set; }
        public int ValorExonerado { get; set; }
        public decimal? ValorInafecto { get; set; }
        public int ValorIsc { get; set; }
        public decimal? ValorIgv { get; set; }
        public int ValorOtrosCargos { get; set; }
        public decimal? Total { get; set; }
        public decimal? TipoDeCambio { get; set; }
        public DateTime ReferenciaFechaEmision { get; set; }
        public string ReferenciaTipoComprobantePagoCodigo { get; set; } = null!;
        public string ReferenciaNumeroSerie { get; set; } = null!;
        public string ReferenciaNumero { get; set; } = null!;
        public string ModalidadCreditoCodigo { get; set; } = null!;
        public string ModalidadCreditoDescripcion { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string ZonaCodigo { get; set; } = null!;
        public string AlmacenCodigo { get; set; } = null!;
        public int SucursalId { get; set; }
        public string TipoCp { get; set; } = null!;
        public int Idperiodo { get; set; }
        public int Idmoneda { get; set; }
        public bool MonedaBase { get; set; }
        public int ComprobanteId { get; set; }
        public string? ComprobanteRelacionadoTipoCp { get; set; }
        public string? ComprobanteRelacionadoTipoCpCodigo { get; set; }
        public string? ComprobanteRelacionadoTipoCpDescripcion { get; set; }
        public string? ComprobanteRelacionadoTipoCpAbreviacion { get; set; }
        public string? ComprobanteRelacionadoNumero { get; set; }
        public int? ComprobanteRelacionadoTipoCpId { get; set; }
    }
}
