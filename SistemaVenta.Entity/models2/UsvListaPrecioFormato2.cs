using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvListaPrecioFormato2
    {
        public string ListaPrecioDescripcion { get; set; } = null!;
        public string CodigoProducto { get; set; } = null!;
        public string? CodigoInterno { get; set; }
        public string DescripcionProducto { get; set; } = null!;
        public string MarcaProducto { get; set; } = null!;
        public string ClaseProducto { get; set; } = null!;
        public string ClaseProductoPadre { get; set; } = null!;
        public string ListaPrecioProductoUnidadAbreviacion { get; set; } = null!;
        public decimal ListaPrecioProductoEscalaPrecioValorVenta { get; set; }
        public decimal ListaPrecioProductoEscalaPrecioIncImpto { get; set; }
        public int? StockPdv02 { get; set; }
        public int? StockPdv04 { get; set; }
        public int? StockPdv05 { get; set; }
        public int? StockPdv06 { get; set; }
        public int? StockPdv07 { get; set; }
        public int? StockPdv09 { get; set; }
        public int? StockSinMoviento { get; set; }
    }
}
