using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptStockMinimo2
    {
        public int ClaseId { get; set; }
        public string ClaseCodigo { get; set; } = null!;
        public string ClaseDescripcion { get; set; } = null!;
        public int ProductoId { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public int UnidadBaseId { get; set; }
        public string UnidadBaseAbre { get; set; } = null!;
        public int UnidadRefId { get; set; }
        public string UnidadRefAbre { get; set; } = null!;
        public int UnidadRefFactor { get; set; }
        public decimal Stock { get; set; }
        public decimal StockPorRecibir { get; set; }
        public decimal StockPorEntregar { get; set; }
        public decimal StockContable { get; set; }
        public decimal StockMinimo { get; set; }
        public int ProveedorId { get; set; }
        public string ProveedorCodigo { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public decimal? PorcentajeReposicion { get; set; }
        public string TienenPorRecibir { get; set; } = null!;
        public string Nivelr { get; set; } = null!;
    }
}
