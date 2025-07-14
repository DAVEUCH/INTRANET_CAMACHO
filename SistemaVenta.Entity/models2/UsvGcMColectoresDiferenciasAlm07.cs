using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvGcMColectoresDiferenciasAlm07
    {
        public string? Almacen { get; set; }
        public string? CodigoColector { get; set; }
        public int? Cantidad { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string DescripProducto { get; set; } = null!;
        public string UnidadReferencia { get; set; } = null!;
        public string MarcaProducto { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string ClaseProducto { get; set; } = null!;
        public int StockFisico { get; set; }
    }
}
