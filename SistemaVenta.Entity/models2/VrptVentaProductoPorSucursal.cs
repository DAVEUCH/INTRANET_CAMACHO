using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptVentaProductoPorSucursal
    {
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public string ProductoUnidadCompraAbreviacion { get; set; } = null!;
        public int ProductoUnidadCompraFactor { get; set; }
        public string ProductoSucursalNombre { get; set; } = null!;
        public int? ProductoSucursalUnidadBaseStock { get; set; }
        public decimal? Cantidad { get; set; }
        public int Idsucursal { get; set; }
        public int? Idproveedor { get; set; }
    }
}
