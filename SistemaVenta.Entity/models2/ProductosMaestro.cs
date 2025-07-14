using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductosMaestro
    {
        public int? Idproducto { get; set; }
        public string? CodigoProducto { get; set; }
        public string? CodigoInterno { get; set; }
        public string? DescripProducto { get; set; }
        public string? AplicaProducto { get; set; }
        public string? MarcaProducto { get; set; }
        public string? ClaseProducto { get; set; }
        public string? ClasePadreProducto { get; set; }
        public string? UmedidaProducto { get; set; }
        public int? FactorProducto { get; set; }
        public string? ProveedorProducto { get; set; }
        public bool? Activo { get; set; }
    }
}
