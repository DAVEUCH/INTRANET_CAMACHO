using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAuxiliarKardexProducto
    {
        public int IdclaseProductoServicio { get; set; }
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public DateTime Fecha { get; set; }
        public int? Movimiento { get; set; }
        public int Idsucursal { get; set; }
    }
}
