using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VHelperLineaCreditoPedido
    {
        public int Pkid { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public string EstadoAprobacion { get; set; } = null!;
        public string EstadoFacturacion { get; set; } = null!;
    }
}
