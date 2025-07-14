using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class PedidoFreddy
    {
        public int Pkid { get; set; }
        public decimal? PorcentajeComisionExterna { get; set; }
        public int? IdempresaTransporte { get; set; }

        public virtual Pedido Pk { get; set; } = null!;
    }
}
