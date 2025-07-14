using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RecursoActividad
    {
        public RecursoActividad()
        {
            Programacions = new HashSet<Programacion>();
        }

        public int Pkid { get; set; }
        public int Idrecurso { get; set; }
        public int Idactividad { get; set; }

        public virtual ActividadSoporte IdactividadNavigation { get; set; } = null!;
        public virtual Recurso IdrecursoNavigation { get; set; } = null!;
        public virtual ICollection<Programacion> Programacions { get; set; }
    }
}
