using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EPrestamoLiquidacionTransportistum
    {
        public int Id { get; set; }
        public int PrestamosIdcpCajaSalida { get; set; }
        public int IdliquidacionTransportista { get; set; }
    }
}
