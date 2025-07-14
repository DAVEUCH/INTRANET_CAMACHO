using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInventarioMigrado31072012
    {
        public string NroDocumento { get; set; } = null!;
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public int AlmacenId { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public string Unidad { get; set; } = null!;
        public int UnidadFactor { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Costo { get; set; }
        public string TipoCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal? UnidadCompraCostoPromedio { get; set; }
        public string UnidadCompra { get; set; } = null!;
        public int UnidadCompraFactor { get; set; }
    }
}
