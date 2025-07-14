using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoItemCp
    {
        public int ComprobanteId { get; set; }
        public int ItemId { get; set; }
        public int? ItemTipoItem { get; set; }
        public string ItemDescripcion { get; set; } = null!;
        public string ItemNumeroLote { get; set; } = null!;
        public string ItemObservacion { get; set; } = null!;
        public decimal ItemCantidad { get; set; }
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
        public bool ItemUsarUnidadMedida { get; set; }
        public bool ItemAplicaPercepcion { get; set; }
    }
}
