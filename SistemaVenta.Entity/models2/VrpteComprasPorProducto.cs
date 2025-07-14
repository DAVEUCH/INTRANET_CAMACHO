using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteComprasPorProducto
    {
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public int ProveedorId { get; set; }
        public string ProveedorCodigo { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public int ProductoId { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public int MarcaId { get; set; }
        public string MarcaCodigo { get; set; } = null!;
        public string MarcaDescripcion { get; set; } = null!;
        public int ClaseProductoId { get; set; }
        public string ClaseProductoCodigo { get; set; } = null!;
        public string ClaseProductoDescripcion { get; set; } = null!;
        public int ResponsableId { get; set; }
        public string ResponsableCodigo { get; set; } = null!;
        public string ResponsableNombre { get; set; } = null!;
        public decimal? ValorVenta { get; set; }
        public decimal? Total { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public int FactorUnidadReferencia { get; set; }
        public string AbreviacionUnidadReferencia { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public string NumCp { get; set; } = null!;
        public int ClaseProductoNivel2Id { get; set; }
        public string ClaseProductoNivel2Codigo { get; set; } = null!;
        public string ClaseProductoNivel2Descripcion { get; set; } = null!;
    }
}
