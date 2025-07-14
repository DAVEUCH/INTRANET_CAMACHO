using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductosImportadosAñoMe
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Idproducto { get; set; }
        public int? Idalmacen { get; set; }
        public string? CodAlmacen { get; set; }
        public string? SucursalNombre { get; set; }
        public decimal? ValorCompraDolUnidades { get; set; }
        public decimal? CantComprasUnidades { get; set; }
    }
}
