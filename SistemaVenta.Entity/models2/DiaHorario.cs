using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DiaHorario
    {
        public DiaHorario()
        {
            HoraDia = new HashSet<HoraDium>();
        }

        public int Pkid { get; set; }
        public int Idhorario { get; set; }
        public string Dia { get; set; } = null!;

        public virtual Horario IdhorarioNavigation { get; set; } = null!;
        public virtual ICollection<HoraDium> HoraDia { get; set; }
    }
}
