using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCp
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteHora { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public string ComprobanteObservacion { get; set; } = null!;
        public string? ComprobanteOrigenDestinoNombre { get; set; }
        public decimal ComprobanteTotal { get; set; }
        public decimal ComprobanteValorAfecto { get; set; }
        public decimal ComprobanteValorInafecto { get; set; }
        public decimal ComprobanteValorVenta { get; set; }
        public decimal ComprobanteSubTotal { get; set; }
        public decimal ComprobanteValorDescuento { get; set; }
        public bool ComprobantePreciosIncImpto { get; set; }
        public bool ComprobanteAnulado { get; set; }
        public bool ComprobanteContabilizado { get; set; }
        public bool ComprobantePreliminar { get; set; }
        public bool ComprobanteTercero { get; set; }
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public int PeriodoId { get; set; }
        public string PeriodoDescripcion { get; set; } = null!;
        public int MonedaId { get; set; }
        public string MonedaDescripcion { get; set; } = null!;
        public string MonedaSimbolo { get; set; } = null!;
        public bool MonedaEsBase { get; set; }
        public int TipoComprobanteId { get; set; }
        public string TipoComprobanteCodigo { get; set; } = null!;
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public string TipoComprobanteDescripcion { get; set; } = null!;
        public int ConceptoId { get; set; }
        public string ConceptoCodigo { get; set; } = null!;
        public string ConceptoDescripcion { get; set; } = null!;
        public int OrigenDestinoId { get; set; }
        public string OrigenDestinoNombre { get; set; } = null!;
        public string OrigenDestinoCodigo { get; set; } = null!;
        public bool OrigenDestinoEsEstandar { get; set; }
        public string OrigenDestinoDocumentoIdentidad { get; set; } = null!;
        public string? OrigenDestinoDireccionDescripcion { get; set; }
        public string OrigenDestinoDireccionSucursal { get; set; } = null!;
        public string? OrigenDestinoDireccionDistrito { get; set; }
        public string? OrigenDesitnoDireccionProvincia { get; set; }
        public string? OrigenDestinoDireccionDepartamento { get; set; }
        public int AlmacenId { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public int CobrarPagarId { get; set; }
        public DateTime CobrarPagarFechaVencimiento { get; set; }
        public decimal CobrarPagarSaldo { get; set; }
        public decimal CobrarPagarTotal { get; set; }
        public bool CobrarPagarCredito { get; set; }
        public DateTime CobrarPagarFechaProgramacionPago { get; set; }
        public string CobrarPagarTipo { get; set; } = null!;
        public int CreditoId { get; set; }
        public string CreditoCodigo { get; set; } = null!;
        public string CreditoDescripcion { get; set; } = null!;
        public int CreditoDias { get; set; }
        public int ResponsableId { get; set; }
        public string ResponsableCodigo { get; set; } = null!;
        public string ResponsableNombre { get; set; } = null!;
        public decimal? ComprobanteValorIgv { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdtipoCp { get; set; }
        public int Pkid { get; set; }
        public decimal? ComprobanteMontoPercepcion { get; set; }
        public decimal? ComprobanteMontoDetraccion { get; set; }
        public decimal? ComprobanteTotalNeto { get; set; }
        public decimal? ComprobantePorcentajePercepcion { get; set; }
        public string ComprobanteTipoCp { get; set; } = null!;
        public int ComprobantePagoSunatId { get; set; }
        public string? ComprobantePagoSunatCodigo { get; set; }
        public string? ComprobantePagoSunatDescripcion { get; set; }
        public bool? ComprobanteCredito { get; set; }
        public int IdmotivoAnulacion { get; set; }
    }
}
