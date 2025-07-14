using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalBalanceLineaCreditoCliente
    {
        public int Idcliente { get; set; }
        public decimal? BalanceSoles { get; set; }
        public decimal? BalanceDolares { get; set; }
    }
}
