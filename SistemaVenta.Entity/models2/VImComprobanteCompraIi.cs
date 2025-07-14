using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImComprobanteCompraIi
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteHora { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public string ComprobanteObservacion { get; set; } = null!;
        public string ComprobantePersonaNombre { get; set; } = null!;
        public bool ComprobanteAnulado { get; set; }
        public bool ComprobanteContabilizado { get; set; }
        public bool ComprobantePreliminar { get; set; }
        public string ComprobanteDocIdentidad { get; set; } = null!;
        public bool ComprobantePreciosIncluidoImpuesto { get; set; }
        public string ComprobanteEstadoEntrega { get; set; } = null!;
        public string ComprobanteEstadoDevolucion { get; set; } = null!;
        public string ComprobanteEstadoEntregaDevolucion { get; set; } = null!;
        public string ComprobanteEstadoDescuento { get; set; } = null!;
        public decimal ComprobanteBaseImponibleInafecto { get; set; }
        public decimal ComprobanteBaseImponibleAfecto { get; set; }
        public decimal? ComprobanteMontoImpuesto { get; set; }
        public decimal ComprobanteValorDescuento { get; set; }
        public decimal ComprobanteTotal { get; set; }
        public string? ComprobanteTotalEnLetras { get; set; }
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
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string ItemDescripcion { get; set; } = null!;
        public decimal ItemCantidad { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemBaseImponibleInafecto { get; set; }
        public decimal ItemTotal { get; set; }
        public decimal ItemTotalIncluidoImpuesto { get; set; }
        public int ItemCantidadUnidadBase { get; set; }
        public string ItemUnidadAbreviacion { get; set; } = null!;
        public bool ItemUnidadEsBase { get; set; }
        public string ItemProductoCodigo { get; set; } = null!;
        public string ItemProductoCodigoAfinidad { get; set; } = null!;
        public string ItemProductoCodigoFabrica { get; set; } = null!;
        public string ItemProductoDescripcion { get; set; } = null!;
        public string ItemProductoClasificacionCodigo { get; set; } = null!;
        public string ItemProductoClasificacionDescripcion { get; set; } = null!;
        public string ItemProductoMarcaDescripcion { get; set; } = null!;
        public decimal ItemPorcentajeImpuesto { get; set; }
        public decimal ItemBalanceEntrega { get; set; }
        public bool ItemEsBonificacion { get; set; }
        public bool ItemEsInafecto { get; set; }
        public decimal ItemBalanceDevolucion { get; set; }
        public decimal ItemBalanceEntregaDevolucion { get; set; }
        public decimal ItemBalanceDescuento { get; set; }
        public string ItemNumeroLote { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public int IdtipoCp { get; set; }
    }
}
