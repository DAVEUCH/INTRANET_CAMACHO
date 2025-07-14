using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCanjeLetra
    {
        public int Pkid { get; set; }
        public int IdcanjeLetras { get; set; }
        public int Idletra { get; set; }
        public int Dias { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal MontoTotal { get; set; }

        public virtual CanjeLetra IdcanjeLetrasNavigation { get; set; } = null!;
    }
}
