using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvProductosSinPrecio
    {
        public string Almacen { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string? CodigoInterno { get; set; }
        public string Descripcion { get; set; } = null!;
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public string? Clase { get; set; }
        public string Marca { get; set; } = null!;
        public string? Segmento { get; set; }
        public string? ListaPrecioProductoUnidadAbreviacion { get; set; }
        public decimal? ListaPrecioProductoEscalaPrecioValorVenta { get; set; }
        public decimal? ListaPrecioProductoEscalaPrecioIncImpto { get; set; }
        public int? IdlistaPrecios { get; set; }
        public bool Activo { get; set; }
    }
}
