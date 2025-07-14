using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Nopedido
    {
        public int Pkid { get; set; }
        public DateTime Fecha { get; set; }
        public int Idcliente { get; set; }
        public int Idvendedor { get; set; }
        public int Idmotivonopedido { get; set; }

        public virtual Cliente IdclienteNavigation { get; set; } = null!;
        public virtual MotivoNoPedido IdmotivonopedidoNavigation { get; set; } = null!;
        public virtual Vendedor IdvendedorNavigation { get; set; } = null!;
    }
}
