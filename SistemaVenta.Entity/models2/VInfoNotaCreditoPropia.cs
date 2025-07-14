using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoNotaCreditoPropia
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
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
        public string SucursalNombre { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public int ConceptoId { get; set; }
        public string ConceptoCodigo { get; set; } = null!;
        public string ConceptoDescripcion { get; set; } = null!;
        public int OrigenDestinoId { get; set; }
        public string OrigenDestinoNombre { get; set; } = null!;
        public string OrigenDestinoCodigo { get; set; } = null!;
        public string? ClienteDocumentoIdentidad { get; set; }
        public string? OrigenDestinoDireccionDescripcion { get; set; }
        public string OrigenDestinoDireccionSucursal { get; set; } = null!;
        public string? OrigenDestinoDireccionDistrito { get; set; }
        public string? OrigenDesitnoDireccionProvincia { get; set; }
        public string? OrigenDestinoDireccionDepartamento { get; set; }
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
        public string? ItemDescripcion { get; set; }
        public string? ItemNumeroLote { get; set; }
        public string? ItemObservacion { get; set; }
        public decimal? ItemCantidad { get; set; }
        public decimal? ItemValorUnitario { get; set; }
        public decimal? ItemTotal { get; set; }
        public int? ItemFactor { get; set; }
        public int? ItemCantidadBase { get; set; }
        public decimal? ItemPorcentajeImpto { get; set; }
        public bool? ItemInafecto { get; set; }
        public bool? ItemBonificacion { get; set; }
        public decimal? ItemSubTotal { get; set; }
        public decimal? ItemValorAfecto { get; set; }
        public decimal? ItemValorInafecto { get; set; }
        public decimal? ItemVarloVenta { get; set; }
        public decimal? ItemValorDescuento { get; set; }
        public int? ItemUnidadId { get; set; }
        public string? ItemUnidadAbreviacion { get; set; }
        public bool? ItemUnidadEsBase { get; set; }
        public int? ItemProductoId { get; set; }
        public string? ItemProductoCodigo { get; set; }
        public string? ItemProductoCodigoAfinidad { get; set; }
        public string? ItemProductoCodigoFabrica { get; set; }
        public string? ItemProductoDescripcion { get; set; }
        public int? ItemProductoClasificacionId { get; set; }
        public string? ItemProductoClasificacionCodigo { get; set; }
        public string? ItemProductoClasificacionDescripcion { get; set; }
        public int? ItemProductoMarcaId { get; set; }
        public string? ItemProductoMarcaDescripcion { get; set; }
        public string? ClienteZonaCodigo { get; set; }
        public string? ClienteZonaDescripcion { get; set; }
        public int AlmacenId { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public string? RelacionadoTipoCodigo { get; set; }
        public string? RelacionadoTipoDescripcion { get; set; }
        public string? RelacionadoTipoAbreviacion { get; set; }
        public string? RelacionadoNumCp { get; set; }
        public string? ComprobanteTotalEnLetras { get; set; }
        public string? MonedaSimbolo { get; set; }
        public decimal? ComprobanteMontoPercepcion { get; set; }
        public decimal? ComprobanteMontoDetraccion { get; set; }
        public bool? ItemAplicaPercepcion { get; set; }
        public string? ClienteNombre { get; set; }
        public decimal? ComprobanteImpuesto { get; set; }
        public DateTime? RelacionadoFechaEmision { get; set; }
        public decimal? ComprobantePorcentajePercepcion { get; set; }
        public string? CienteDireccion2 { get; set; }
        public int? IdmotivoAnulacion { get; set; }
        public string? MotivoDesc { get; set; }
        public string? MotivoCodigo { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdtipoCp { get; set; }
        public decimal? ItemProductoDscto { get; set; }
        public string? ComprobanteDocIdentidad { get; set; }
        public string CodigoCliente { get; set; } = null!;
        public string? NumCpRelacionados { get; set; }
        public DateTime? FechaCpRelacionado { get; set; }
        public string? MotivoAnulacionDescripcion { get; set; }
    }
}
