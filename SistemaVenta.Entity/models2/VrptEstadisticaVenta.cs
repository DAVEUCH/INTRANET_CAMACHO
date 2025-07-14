using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptEstadisticaVenta
    {
        public int Idsucursal { get; set; }
        public int Idproducto { get; set; }
        public int Idmarca { get; set; }
        public int? Idproveedor { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
    }
}
