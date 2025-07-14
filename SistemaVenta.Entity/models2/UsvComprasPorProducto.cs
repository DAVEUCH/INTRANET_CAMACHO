using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprasPorProducto
    {
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public int ProveedorId { get; set; }
        public string ProveedorNombre { get; set; } = null!;
        public int ProductoId { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public int MarcaId { get; set; }
        public string MarcaDescripcion { get; set; } = null!;
        public decimal? ValorVenta { get; set; }
        public decimal? Total { get; set; }
        public int? CantidadUnidadBase { get; set; }
        public int FactorUnidadReferencia { get; set; }
        public string AbreviacionUnidadReferencia { get; set; } = null!;
    }
}
