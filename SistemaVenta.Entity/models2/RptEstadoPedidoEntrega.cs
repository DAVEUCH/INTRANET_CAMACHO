using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RptEstadoPedidoEntrega
    {
        public int Idpedido { get; set; }
        public int Idcpnivel1 { get; set; }
        public DateTime Nivel1Fecha { get; set; }
        public string Nivel1NumCp { get; set; } = null!;
        public int MovStockFisico { get; set; }
        public string Tabla { get; set; } = null!;
    }
}
