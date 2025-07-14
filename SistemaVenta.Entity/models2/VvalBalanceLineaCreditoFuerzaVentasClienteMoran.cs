using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalBalanceLineaCreditoFuerzaVentasClienteMoran
    {
        public int Idcliente { get; set; }
        public int IdlineaCreditoPorFuerzaVentas { get; set; }
        public decimal? BalanceSoles { get; set; }
        public decimal? BalanceDolares { get; set; }
    }
}
