using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoResumenVenta
    {
        public string? ItemProductoCodigo { get; set; }
        public string? ItemProductoDescripcion { get; set; }
        public string? ItemProductoClasificacionCodigo { get; set; }
        public string? ItemProductoClasificacionDescripcion { get; set; }
        public decimal? SumaItemCantidad { get; set; }
        public decimal? SumaItemValorVenta { get; set; }
        public decimal? SumaItemTotalDescuento { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public int? SucursalId { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? ItemProductoMarcaDescripcion { get; set; }
    }
}
