using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionListaPrecio2
    {
        public string ListaPrecioDescripcion { get; set; } = null!;
        public string ListaPrecioMonedaSimbolo { get; set; } = null!;
        public string CodigoProducto { get; set; } = null!;
        public string? CodigoInterno { get; set; }
        public string DescripcionProducto { get; set; } = null!;
        public string MarcaProducto { get; set; } = null!;
        public string ClaseProducto { get; set; } = null!;
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Año { get; set; }
        public string? Motor { get; set; }
        public string? Cilindros { get; set; }
        public string? Litros { get; set; }
        public string? Medidas { get; set; }
        public string? Voltios { get; set; }
        public string? Tipoencendido { get; set; }
        public string? Lado { get; set; }
        public string ListaPrecioProductoUnidadAbreviacion { get; set; } = null!;
        public string ListaPrecioProductoUnidadDescripcion { get; set; } = null!;
        public int ListaPrecioProductoEscalaDesde { get; set; }
        public int ListaPrecioProductoEscalaHasta { get; set; }
        public decimal DescuentoA { get; set; }
        public decimal DescuentoB { get; set; }
        public decimal ListaPrecioProductoEscalaPrecioValorVenta { get; set; }
        public decimal ListaPrecioProductoEscalaPrecioIncImpto { get; set; }
        public int? StockPdv02 { get; set; }
        public int? StockPdv04 { get; set; }
        public int? StockPdv05 { get; set; }
        public int? StockPdv06 { get; set; }
        public int? StockPdv07 { get; set; }
        public int? StockPdv09 { get; set; }
        public int? StockSinMoviento { get; set; }
        public DateTime ListaPrecioFechaUltimaModificacion { get; set; }
        public int ListaPrecioProductoId { get; set; }
        public string? ProveedorCodigo { get; set; }
        public string? ProveedorNombre { get; set; }
    }
}
