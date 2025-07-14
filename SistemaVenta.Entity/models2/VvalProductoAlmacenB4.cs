using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalProductoAlmacenB4
    {
        public int Idalmacen { get; set; }
        public int Idproducto { get; set; }
        public int? CantidadFisico { get; set; }
        public int? CantidadContable { get; set; }
        public int? CantidadPorEntregar { get; set; }
        public int? CantidadPorRecibir { get; set; }
    }
}
