using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImpresionLoteNotaCredito
    {
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteHora { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public string ComprobanteObservacion { get; set; } = null!;
        public string ComprobantePersonaNombre { get; set; } = null!;
        public decimal ComprobanteTotal { get; set; }
        public decimal ComprobanteValorAfecto { get; set; }
        public decimal ComprobanteValorInafecto { get; set; }
        public decimal ComprobanteValorVenta { get; set; }
        public decimal ComprobanteSubTotal { get; set; }
        public decimal? ComprobanteValorIgv { get; set; }
        public decimal ComprobanteValorDescuento { get; set; }
        public bool ComprobantePreciosIncImpto { get; set; }
        public bool ComprobanteAnulado { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public string PeriodoDescripcion { get; set; } = null!;
        public string MonedaDescripcion { get; set; } = null!;
        public string MonedaSimbolo { get; set; } = null!;
        public string TipoComprobanteCodigo { get; set; } = null!;
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public string ConceptoCodigo { get; set; } = null!;
        public string ConceptoDescripcion { get; set; } = null!;
        public string PersonaNombre { get; set; } = null!;
        public string PersonaCodigo { get; set; } = null!;
        public string PersonaDocumentoIdentidad { get; set; } = null!;
        public string PersonaDireccionDescripcion { get; set; } = null!;
        public string PersonaDireccionSucursal { get; set; } = null!;
        public string PersonaDireccionDistrito { get; set; } = null!;
        public string PersonaDireccionProvincia { get; set; } = null!;
        public string PersonaDireccionDepartamento { get; set; } = null!;
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public DateTime CobrarPagarFechaVencimiento { get; set; }
        public decimal CobrarPagarSaldo { get; set; }
        public decimal CobrarPagarTotal { get; set; }
        public bool CobrarPagarCredito { get; set; }
        public DateTime CobrarPagarFechaProgramacionPago { get; set; }
        public string CobrarPagarTipo { get; set; } = null!;
        public string CreditoCodigo { get; set; } = null!;
        public string CreditoDescripcion { get; set; } = null!;
        public int CreditoDias { get; set; }
        public string ResponsableCodigo { get; set; } = null!;
        public string ResponsableNombre { get; set; } = null!;
        public string? ItemCodigo { get; set; }
        public string? ItemDescripcion { get; set; }
        public decimal ItemCantidad { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemSubTotal { get; set; }
        public decimal ItemTotal { get; set; }
        public string? ClienteZonaCodigo { get; set; }
        public string? ClienteZonaDescripcion { get; set; }
        public string? ClienteZonaRepartoCodigo { get; set; }
        public string? ClienteZonaRepartoDescripcion { get; set; }
        public string? RelacionadoTipoCodigo { get; set; }
        public string? RelacionadoTipoDescripcion { get; set; }
        public string? RelacionadoTipoAbreviacion { get; set; }
        public string? RelacionadoNumCp { get; set; }
        public string? RelacionadoAlmacenCodigo { get; set; }
        public string? RelacionadoAlmacenNombre { get; set; }
        public string NumCp { get; set; } = null!;
        public int Pkid { get; set; }
        public int IdtipoCp { get; set; }
        public int? ItemProductoId { get; set; }
        public int? ItemProductoClasificacionId { get; set; }
        public string? ItemProductoClasificacionCodigo { get; set; }
        public string? ItemProductoClasificacionDescripcion { get; set; }
        public int? Idsucursal { get; set; }
        public bool ItemInafecto { get; set; }
    }
}
