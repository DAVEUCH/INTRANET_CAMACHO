using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EGastoLiquidacionTransportistum
    {
        public int Id { get; set; }
        public int GastosIdcpCompra { get; set; }
        public int IdliquidacionTransportista { get; set; }
    }
}
