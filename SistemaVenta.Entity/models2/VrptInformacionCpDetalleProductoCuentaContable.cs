using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionCpDetalleProductoCuentaContable
    {
        public int ComprobanteId { get; set; }
        public int ItemId { get; set; }
        public int? ItemTipoItem { get; set; }
        public string ItemDescripcion { get; set; } = null!;
        public decimal ItemCantidad { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemTotal { get; set; }
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
        public string ItemCuentaContableCuenta { get; set; } = null!;
        public string ItemCuentaContableDescripcion { get; set; } = null!;
    }
}
