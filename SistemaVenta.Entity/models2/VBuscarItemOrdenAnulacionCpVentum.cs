using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VBuscarItemOrdenAnulacionCpVentum
    {
        public int IdcpVenta { get; set; }
        public decimal? Cantidad { get; set; }
        public int Idproducto { get; set; }
    }
}
