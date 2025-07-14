using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptMovimientoProductoNotaCredito
    {
        public DateTime Fecha { get; set; }
        public int Idsucursal { get; set; }
        public int Idalmacen { get; set; }
        public int? Idproveedor { get; set; }
        public int Idproducto { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
