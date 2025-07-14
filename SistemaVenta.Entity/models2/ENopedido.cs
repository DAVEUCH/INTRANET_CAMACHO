using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ENopedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Idcliente { get; set; }
        public int Idvendedor { get; set; }
        public int Idmotivonopedido { get; set; }
    }
}
