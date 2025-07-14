using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Horario
    {
        public Horario()
        {
            DiaHorarios = new HashSet<DiaHorario>();
            Recursos = new HashSet<Recurso>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<DiaHorario> DiaHorarios { get; set; }
        public virtual ICollection<Recurso> Recursos { get; set; }
    }
}
