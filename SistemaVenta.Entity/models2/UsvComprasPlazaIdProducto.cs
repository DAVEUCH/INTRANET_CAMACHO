using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprasPlazaIdProducto
    {
        public int IdDocCompra { get; set; }
        public DateTime Fecha { get; set; }
        public int Idsucursal { get; set; }
        public int Idproducto { get; set; }
    }
}
