using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Programacion
    {
        public int Pkid { get; set; }
        public int IdrecursoActividad { get; set; }
        public string Dia { get; set; } = null!;
        public string Hora { get; set; } = null!;
        public DateTime Fecha { get; set; }

        public virtual RecursoActividad IdrecursoActividadNavigation { get; set; } = null!;
    }
}
