using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvRelacionPedidoGuiaV2
    {
        public int PkidOp { get; set; }
        public DateTime FechaOp { get; set; }
        public DateTime HoraOp { get; set; }
        public string Op { get; set; } = null!;
        public int PkidGuia { get; set; }
        public DateTime FechaGuia { get; set; }
        public DateTime HoraGuia { get; set; }
        public string Guia { get; set; } = null!;
    }
}
