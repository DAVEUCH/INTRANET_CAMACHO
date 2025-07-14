using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoProductoAgrupacion
    {
        public int IdproductoPadre { get; set; }
        public int Idproducto { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public int Idmarca { get; set; }
        public int? Idproveedor { get; set; }
        public string ProductoCodigoAgrupacion { get; set; } = null!;
        public string ProductoDescripcionAgrupacion { get; set; } = null!;
        public string UnidadBaseAbreviacionAgrupacion { get; set; } = null!;
        public string UnidadReferenciaAbreviacionAgrupacion { get; set; } = null!;
        public int ProductoUnidadReferenciaFactorAgrupacion { get; set; }
        public string? LoteAgrupacion { get; set; }
        public DateTime? LoteFechaIngresoAgrupacion { get; set; }
        public DateTime? LoteFechaVencimientoAgrupacion { get; set; }
        public decimal? CantidadUnidadBaseAgrupacion { get; set; }
    }
}
