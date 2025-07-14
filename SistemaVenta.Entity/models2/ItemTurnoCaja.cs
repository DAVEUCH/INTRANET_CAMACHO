using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemTurnoCaja
    {
        public int Pkid { get; set; }
        public int IdturnoCaja { get; set; }
        public int Idcp { get; set; }

        public virtual Cp IdcpNavigation { get; set; } = null!;
        public virtual TurnoCaja IdturnoCajaNavigation { get; set; } = null!;
    }
}
