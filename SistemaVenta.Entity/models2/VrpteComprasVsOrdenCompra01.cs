using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteComprasVsOrdenCompra01
    {
        public int OrdenIdsucursal { get; set; }
        public string OrdenSucursal { get; set; } = null!;
        public int OrdenIdproveedor { get; set; }
        public string OrdenCodProveedor { get; set; } = null!;
        public string OrdenProveedor { get; set; } = null!;
        public int OrdenIdclase { get; set; }
        public string OrdenCodClase { get; set; } = null!;
        public string OrdenClase { get; set; } = null!;
        public int OrdenIdmarca { get; set; }
        public string OrdenMarca { get; set; } = null!;
        public int OrdenIdproducto { get; set; }
        public string OrdenCodProducto { get; set; } = null!;
        public string OrdenProducto { get; set; } = null!;
        public string OrdenUnidadReferencia { get; set; } = null!;
        public decimal? OrdenImporteCompra { get; set; }
        public int? OrdenCantidadCompra { get; set; }
        public decimal? CompraImporteCompra { get; set; }
        public int? CompraCantidadCompra { get; set; }
        public DateTime? OrdenFecha { get; set; }
        public int FactorUnidadReferencia { get; set; }
        public string OrdenUnidadBase { get; set; } = null!;
    }
}
