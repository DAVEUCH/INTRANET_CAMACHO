using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcPedidosClienteProvLetra
    {
        public int Pkid { get; set; }
        public int? IdprovisionLetras { get; set; }
        public int? Idpedido { get; set; }
        public decimal? ImpLetra { get; set; }
        public DateTime? FechaVcto { get; set; }
    }
}
