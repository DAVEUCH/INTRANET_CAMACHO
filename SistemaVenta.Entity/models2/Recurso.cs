using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Recurso
    {
        public Recurso()
        {
            RecursoActividads = new HashSet<RecursoActividad>();
        }

        public int Pkid { get; set; }
        public int Idhorario { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual Horario IdhorarioNavigation { get; set; } = null!;
        public virtual ICollection<RecursoActividad> RecursoActividads { get; set; }
    }
}
