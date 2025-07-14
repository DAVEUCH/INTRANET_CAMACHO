using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoLiquidacionCaja
    {
        public int Pkid { get; set; }
        public int Idcaja { get; set; }
        public bool RestringirCaja { get; set; }
    }
}
