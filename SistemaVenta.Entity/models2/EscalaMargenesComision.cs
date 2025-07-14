using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EscalaMargenesComision
    {
        public int Pkid { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
