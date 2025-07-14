using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductosComprobantesImportado
    {
        public string? NumeroCp { get; set; }
        public DateTime? FechaCp { get; set; }
        public int? Idproducto { get; set; }
        public int? Idalmacen { get; set; }
        public string? CodAlmacen { get; set; }
        public string? SucursalNombre { get; set; }
        public string? ProveedorProducto { get; set; }
        public decimal? CantCompra { get; set; }
        public int? FactorCompra { get; set; }
        public decimal? ValorCompraDol { get; set; }
        public decimal? ValorCompraDolUnidades { get; set; }
        public decimal? CantComprasUnidades { get; set; }
    }
}
