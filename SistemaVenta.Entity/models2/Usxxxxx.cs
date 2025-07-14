using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Usxxxxx
    {
        public string CodAlmacen { get; set; } = null!;
        public string CodigoProducto { get; set; } = null!;
        public int Cantidad { get; set; }
        public string DescripProducto { get; set; } = null!;
        public string UnidadReferencia { get; set; } = null!;
        public string MarcaProducto { get; set; } = null!;
        public string ClaseProducto { get; set; } = null!;
        public int StockFisico { get; set; }
        public int? Dife { get; set; }
        public decimal CostoUltimaCompraDolares { get; set; }
    }
}
