using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class HoraDium
    {
        public int Pkid { get; set; }
        public int IddiaHorario { get; set; }
        public string Hora { get; set; } = null!;

        public virtual DiaHorario IddiaHorarioNavigation { get; set; } = null!;
    }
}
