using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoitemcpproducto
    {
        public int ComprobanteId { get; set; }
        public int ItemId { get; set; }
        public int? ItemTipoItem { get; set; }
        public string? ItemDescripcion { get; set; }
        public string? ItemCodigo { get; set; }
        public string? ItemNumeroLote { get; set; }
        public string? ItemObservacion { get; set; }
        public decimal ItemCantidad { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemTotal { get; set; }
        public int? ItemFactor { get; set; }
        public int? ItemCantidadBase { get; set; }
        public decimal ItemPorcentajeImpto { get; set; }
        public bool ItemInafecto { get; set; }
        public bool ItemBonificacion { get; set; }
        public decimal ItemSubTotal { get; set; }
        public decimal ItemValorAfecto { get; set; }
        public decimal ItemValorInafecto { get; set; }
        public decimal ItemVarloVenta { get; set; }
        public decimal ItemValorDescuento { get; set; }
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
        public string Descripcion { get; set; } = null!;
        public decimal? ItemProductoPeso { get; set; }
        public decimal ItemProductoDscto { get; set; }
        public decimal ItemProductoRecargo { get; set; }
    }
}
