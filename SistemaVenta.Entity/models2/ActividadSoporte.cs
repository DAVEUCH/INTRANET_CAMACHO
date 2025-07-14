using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ActividadSoporte
    {
        public ActividadSoporte()
        {
            RecursoActividads = new HashSet<RecursoActividad>();
        }

        public int Pkid { get; set; }
        public int IdsolicitudSoporte { get; set; }
        public int Idresponsable { get; set; }
        public int Idestado { get; set; }
        public string Detalle { get; set; } = null!;
        public string Solucion { get; set; } = null!;
        public DateTime FechaInicio { get; set; }
        public int Duracion { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual Empleado IdresponsableNavigation { get; set; } = null!;
        public virtual SolicitudSoporte IdsolicitudSoporteNavigation { get; set; } = null!;
        public virtual ICollection<RecursoActividad> RecursoActividads { get; set; }
    }
}
