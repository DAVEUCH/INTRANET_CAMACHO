using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoPedidoGral
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
        public int? OrigenDestinoId { get; set; }
        public string? OrigenDestinoNombre { get; set; }
        public string? OrigenDestinoCodigo { get; set; }
        public bool? OrigenDestinoEsEstandar { get; set; }
        public string OrigenDestinoDocumentoIdentidad { get; set; } = null!;
        public string? OrigenDestinoDireccionDescripcion { get; set; }
        public string OrigenDestinoDireccionSucursal { get; set; } = null!;
        public string? OrigenDestinoDireccionDistrito { get; set; }
        public string? OrigenDesitnoDireccionProvincia { get; set; }
        public string? OrigenDestinoDireccionDepartamento { get; set; }
        public int AlmacenId { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public int CreditoId { get; set; }
        public string CreditoCodigo { get; set; } = null!;
        public string CreditoDescripcion { get; set; } = null!;
        public int CreditoDias { get; set; }
        public int ResponsableId { get; set; }
        public string ResponsableCodigo { get; set; } = null!;
        public string ResponsableNombre { get; set; } = null!;
        public decimal? ComprobanteValorIgv { get; set; }
        public string NumCp { get; set; } = null!;
        public decimal? ComprobanteTotalNeto { get; set; }
        public string ComprobanteTipoCp { get; set; } = null!;
        public string? ComprobantePagoSunatDescripcion { get; set; }
        public bool? ComprobanteCredito { get; set; }
        public int ItemId { get; set; }
        public string ItemDescripcion { get; set; } = null!;
        public decimal ItemCantidad { get; set; }
        public int? ItemTipoItem { get; set; }
        public string ItemNumeroLote { get; set; } = null!;
        public string ItemObservacion { get; set; } = null!;
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemTotal { get; set; }
        public int ItemFactor { get; set; }
        public int ItemCantidadBase { get; set; }
        public decimal ItemPorcentajeImpto { get; set; }
        public bool ItemInafecto { get; set; }
        public bool ItemBonificacion { get; set; }
        public decimal ItemSubTotal { get; set; }
        public decimal ItemValorAfecto { get; set; }
        public decimal ItemValorInafecto { get; set; }
        public decimal ItemVarloVenta { get; set; }
        public decimal ItemValorDescuento { get; set; }
        public int ItemUnidadId { get; set; }
        public string ItemUnidadAbreviacion { get; set; } = null!;
        public bool ItemUnidadEsBase { get; set; }
        public int ItemProductoId { get; set; }
        public string ItemProductoCodigo { get; set; } = null!;
        public string ItemProductoCodigoAfinidad { get; set; } = null!;
        public string ItemProductoCodigoFabrica { get; set; } = null!;
        public string ItemProductoDescripcion { get; set; } = null!;
        public int ItemProductoClasificacionId { get; set; }
        public string ItemProductoClasificacionCodigo { get; set; } = null!;
        public string ItemProductoClasificacionDescripcion { get; set; } = null!;
        public int ItemProductoMarcaId { get; set; }
        public string ItemProductoMarcaDescripcion { get; set; } = null!;
        public int IdcentroDeCostoId { get; set; }
        public decimal ItemProductoPeso { get; set; }
        public decimal ItemProductoLargo { get; set; }
        public decimal ItemProductoAncho { get; set; }
        public decimal ItemProductoLargoB { get; set; }
        public decimal ItemProductoAnchoB { get; set; }
        public int ItemUnidadMedidaOrigenId { get; set; }
        public int ItemUnidadMedidaDestinoId { get; set; }
        public int ItemConversionUnidadId { get; set; }
        public decimal ItemCantidadB { get; set; }
        public decimal ItemPrecioB { get; set; }
        public int ItemFactorConversion { get; set; }
        public decimal ItemProductoBalanceEntrega { get; set; }
        public decimal ItemProductoBalanceFacturacion { get; set; }
        public decimal ItemProductoPrecioLista { get; set; }
        public decimal? ItemProductoDescuentoAplicado { get; set; }
        public bool ItemProductoDescuentoFijo { get; set; }
        public decimal ItemProductoCantidadPedida { get; set; }
        public bool ItemUsarUnidadMedida { get; set; }
        public int? ComprobanteValorado { get; set; }
    }
}
