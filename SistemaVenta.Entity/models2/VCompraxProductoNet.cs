using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCompraxProductoNet
    {
        public string Proveedor { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Unidad { get; set; } = null!;
        public int IdProducto { get; set; }
        public string Codigo { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public decimal Total { get; set; }
        public decimal? Cuc { get; set; }
        public DateTime FechaEmision { get; set; }
        public int Idproveedor { get; set; }
        public string NumCp { get; set; } = null!;
    }
}
