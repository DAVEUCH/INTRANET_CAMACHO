using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranGuiaSalidaInterna
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteHora { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public string ComprobanteObservacion { get; set; } = null!;
        public string? ComprobanteOrigenDestinoNombre { get; set; }
        public decimal ComprobanteBaseImponibleAfecto { get; set; }
        public decimal ComprobanteBaseImponibleInafecto { get; set; }
        public decimal? ComprobanteMontoImpuesto { get; set; }
        public decimal ComprobanteTotal { get; set; }
        public bool ComprobantePreciosIncluidoImpuesto { get; set; }
        public bool ComprobanteAnulado { get; set; }
        public bool ComprobanteContabilizado { get; set; }
        public bool ComprobantePreliminar { get; set; }
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
        public int ConceptoId { get; set; }
        public string ConceptoCodigo { get; set; } = null!;
        public string ConceptoDescripcion { get; set; } = null!;
        public string ComprobanteTipoOrigenDestino { get; set; } = null!;
        public int? OrigenDestinoId { get; set; }
        public string? OrigenDestinoNombre { get; set; }
        public string? OrigenDestinoCodigo { get; set; }
        public bool? OrigenDestinoEsEstandar { get; set; }
        public string OrigenDestinoDocumentoIdentidad { get; set; } = null!;
        public string OrigenDestinoDireccionSucursal { get; set; } = null!;
        public string? OrigenDestinoDireccionDistrito { get; set; }
        public string? OrigenDesitnoDireccionProvincia { get; set; }
        public string? OrigenDestinoDireccionDepartamento { get; set; }
        public string MotivoAnulacionId { get; set; } = null!;
        public string MotivoAnulacionCodigo { get; set; } = null!;
        public string MotivoAnulacionDescripcion { get; set; } = null!;
        public string MotivoAnulacionOficina { get; set; } = null!;
        public int AlmacenId { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public int ItemId { get; set; }
        public int? ItemTipoItem { get; set; }
        public string? ItemDescripcion { get; set; }
        public decimal ItemCantidad { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemBaseImponibleAfecto { get; set; }
        public decimal ItemBaseImponibleInafecto { get; set; }
        public decimal ItemTotal { get; set; }
        public decimal ItemPorcentajeImpto { get; set; }
        public int? ItemCantidadUnidadBase { get; set; }
        public int? ItemFactor { get; set; }
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
        public int ItemBalanceFacturacion { get; set; }
        public int ItemBalanceDevolucion { get; set; }
        public bool ItemEsBonificacion { get; set; }
        public bool ItemEsInafecto { get; set; }
        public string ComprobanteOrigenNumCp { get; set; } = null!;
        public int IdtipoCp { get; set; }
        public string NumCp { get; set; } = null!;
        public string? NumeroLote { get; set; }
        public string ResponsableNombre { get; set; } = null!;
    }
}
