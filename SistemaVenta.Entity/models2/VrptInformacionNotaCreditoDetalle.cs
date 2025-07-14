using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionNotaCreditoDetalle
    {
        public string ComprobanteItemUnidadVentaAbreviacion { get; set; } = null!;
        public int ComprobanteItemUnidadVentaFactor { get; set; }
        public decimal? ComprobanteItemValorVenta { get; set; }
        public decimal ComprobanteItemBaseImponibleAfectoInafecto { get; set; }
        public decimal ComprobanteItemTotalIncImpto { get; set; }
        public int ComprobanteItemCantidadUnidadBase { get; set; }
        public decimal ComprobanteItemCantidadUnidadVenta { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public decimal? ComprobanteItemPeso { get; set; }
        public decimal? ComprobanteItemVolumen { get; set; }
        public string ProductoProveedorCodigo { get; set; } = null!;
        public string ProductoProveedorNombre { get; set; } = null!;
        public string ProductoClaseProductoServicioCodigo { get; set; } = null!;
        public string ProductoClaseProductoServicioDescripcion { get; set; } = null!;
        public string ProductoMarcaDescripcion { get; set; } = null!;
        public string ProductoUnidadBaseAbreviacion { get; set; } = null!;
        public int ProductoUnidadReferenciaFactor { get; set; }
        public string ProductoUnidadReferenciaAbreviacion { get; set; } = null!;
        public int ProductoProveedorId { get; set; }
        public int ProductoClaseProductoId { get; set; }
        public int ProductoMarcaId { get; set; }
        public int ProductoId { get; set; }
        public int ComprobanteId { get; set; }
    }
}
