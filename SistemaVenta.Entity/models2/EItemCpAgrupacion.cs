using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCpAgrupacion
    {
        public int Pkid { get; set; }
        public int IditemProducto { get; set; }
        public int Idproducto { get; set; }
        public int Cantidad { get; set; }
        public int Idcp { get; set; }
    }
}
