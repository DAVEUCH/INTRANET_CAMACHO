using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoInventarioTransferencium
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteHora { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public string ComprobanteObservacion { get; set; } = null!;
        public string ComprobantePersonaNombre { get; set; } = null!;
        public decimal ComprobanteBaseImponibleAfecto { get; set; }
        public decimal ComprobanteBaseImponibleInafecto { get; set; }
        public decimal? ComprobanteMontoImpuesto { get; set; }
        public decimal ComprobanteTotal { get; set; }
        public bool ComprobanteAnulado { get; set; }
        public bool ComprobanteContabilizado { get; set; }
        public bool ComprobantePreliminar { get; set; }
        public string ComprobanteEstadoFacturacion { get; set; } = null!;
        public string ComprobanteEstadoDevulucion { get; set; } = null!;
        public bool ComprobantePreciosIncluidoImpuesto { get; set; }
        public string ComprobanteNumeroReferencia { get; set; } = null!;
        public string ComprobanteDireccionEntrega { get; set; } = null!;
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
        public string ComprobanteTipoPersona { get; set; } = null!;
        public int PersonaId { get; set; }
        public string PersonaNombre { get; set; } = null!;
        public string PersonaCodigo { get; set; } = null!;
        public bool PersonaEsEstandar { get; set; }
        public string PersonaDocumentoIdentidad { get; set; } = null!;
        public string PersonaDireccionDescripcion { get; set; } = null!;
        public string PersonaDireccionSucursal { get; set; } = null!;
        public string PersonaDireccionDistrito { get; set; } = null!;
        public string PersonaDireccionProvincia { get; set; } = null!;
        public string PersonaDireccionDepartamento { get; set; } = null!;
        public int MotivoAnulacionId { get; set; }
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
        public int IdtipoCp { get; set; }
        public string NumCp { get; set; } = null!;
        public string? NumCpRelacionadosNivel1 { get; set; }
        public string? VehiculoCodigo { get; set; }
        public string? VehiculoNombre { get; set; }
        public decimal? VehiculoCapPeso { get; set; }
        public decimal? VehiculoVolumen { get; set; }
        public string? VehiculoMarca { get; set; }
        public string? VehiculoModelo { get; set; }
        public string? VehiculoPlaca1 { get; set; }
        public string? VehiculoPlaca2 { get; set; }
        public string? ChoferCodigo { get; set; }
        public string? ChoferNombre { get; set; }
        public string? ChoferLicencia { get; set; }
        public string? ProveedorCodigo { get; set; }
        public string? ProveedorNombre { get; set; }
        public string? ItemNumeroLote { get; set; }
        public string? ItemObservacion { get; set; }
        public string? ProveedorDireccion { get; set; }
        public string? ProveedorDireccionDistrito { get; set; }
        public string? ProveedorDireccionProvincia { get; set; }
        public string? ProveedorDireccionDepartamento { get; set; }
        public string? TransportistaRuc { get; set; }
        public int? ProveedorId { get; set; }
        public int? ProveedorDireccionId { get; set; }
    }
}
