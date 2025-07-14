using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmacenesCentrale
    {
        public string? Sucursal { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public decimal ProductoUnidadBaseStock { get; set; }
        public int ProductoUnidadBaseStockAlmacen { get; set; }
        public decimal ProductoUnidadBaseCostoPromedio { get; set; }
        public decimal ProductoUnidadBaseCostoUltimaCompra { get; set; }
        public string UnidadBaseAbreviacion { get; set; } = null!;
        public string UnidadReferenciaAbreviacion { get; set; } = null!;
        public int UnidadReferenciaFactor { get; set; }
        public string AlmacenNombre { get; set; } = null!;
        public string ProveedorCodigo { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public string ClaseProductoServicioCodigo { get; set; } = null!;
        public string ClaseProductoServicioDescripcion { get; set; } = null!;
        public string MarcaDescripcion { get; set; } = null!;
        public int ProductoId { get; set; }
        public int ClaseProductoId { get; set; }
        public int MarcaId { get; set; }
        public int ProveedorId { get; set; }
        public int AlmacenId { get; set; }
    }
}
