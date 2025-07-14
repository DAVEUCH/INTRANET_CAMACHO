using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalLineaCreditoFv
    {
        public int Idcliente { get; set; }
        public decimal? Monto { get; set; }
        public decimal? Saldo { get; set; }
    }
}
