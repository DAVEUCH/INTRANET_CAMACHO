using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VConsultaProductoAlmacen
    {
        public int Idproducto { get; set; }
        public int Idalmacen { get; set; }
        public int StockFisico { get; set; }
        public int StockContable { get; set; }
        public int StockPorEntregar { get; set; }
        public int StockPorRecibir { get; set; }
        public string UnidadRefAbreviacion { get; set; } = null!;
        public int UnidadRefFactor { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public string UnidadBaseAbreviacion { get; set; } = null!;
        public int UnidadBaseFactor { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public int Idsucursal { get; set; }
    }
}
