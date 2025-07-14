using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteUltimasComprasPorProducto
    {
        public int CompraIdsucursal { get; set; }
        public string CompraSucursal { get; set; } = null!;
        public int CompraIdproducto { get; set; }
        public string CompraCodProducto { get; set; } = null!;
        public string CompraProducto { get; set; } = null!;
        public int CompraIdproveedor { get; set; }
        public string CompraCodProveedor { get; set; } = null!;
        public string CompraProveedor { get; set; } = null!;
        public string CompraTipoCp { get; set; } = null!;
        public string CompraUnidad { get; set; } = null!;
        public decimal? CompraImporteCompra { get; set; }
        public int? CompraCantidadCompra { get; set; }
        public DateTime CompraFecha { get; set; }
        public decimal? CompraPrecioUnitario { get; set; }
        public int MovStockContable { get; set; }
        public int MovStockFisico { get; set; }
        public int CompraFactor { get; set; }
    }
}
