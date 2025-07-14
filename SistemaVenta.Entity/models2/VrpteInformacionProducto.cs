using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteInformacionProducto
    {
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public decimal ProductoUnidadBaseStock { get; set; }
        public decimal ProductoUnidadBaseCostoPromedio { get; set; }
        public decimal ProductoUnidadBaseCostoUltimaCompra { get; set; }
        public string ProductoUnidadBaseAbreviacion { get; set; } = null!;
        public string ProductoUnidadReferenciaAbreviacion { get; set; } = null!;
        public int ProductoUnidadReferenciaFactor { get; set; }
        public string ProductoUnidadCompraAbreviacion { get; set; } = null!;
        public int ProductoUnidadCompraFactor { get; set; }
        public string ProductoProveedorCodigo { get; set; } = null!;
        public string ProductoProveedorNombre { get; set; } = null!;
        public string ProductoClaseProductoServicioCodigo { get; set; } = null!;
        public string ProductoClaseProductoServicioDescripcion { get; set; } = null!;
        public string ProductoMarcaDescripcion { get; set; } = null!;
        public int? ProductoDiasReposicion { get; set; }
        public int ProductoId { get; set; }
        public int ProductoClaseProductoId { get; set; }
        public int ProductoMarcaId { get; set; }
        public int ProductoProveedorId { get; set; }
        public int ProductoCaracteristica1Id { get; set; }
        public int ProductoCaracteristica2Id { get; set; }
        public int ProductoCaracteristica3Id { get; set; }
        public int ProductoCaracteristica4Id { get; set; }
        public string ProductoCaracteristica1Descripcion { get; set; } = null!;
        public string ProductoCaracteristica2Descripcion { get; set; } = null!;
        public string ProductoCaracteristica3Descripcion { get; set; } = null!;
        public string ProductoCaracteristica4Descripcion { get; set; } = null!;
    }
}
