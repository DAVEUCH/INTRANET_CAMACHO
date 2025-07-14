using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabReqMercaderiaUltReqProd
    {
        public int Idsucursal { get; set; }
        public int Idproducto { get; set; }
        public DateTime? UltFechaReq { get; set; }
    }
}
