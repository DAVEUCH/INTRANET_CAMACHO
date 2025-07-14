using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Actividad
    {
        public Actividad()
        {
            Comando2s = new HashSet<Comando2>();
            SubActividads = new HashSet<SubActividad>();
        }

        public string Pkid { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Especificacion { get; set; } = null!;
        public string NombreSubActividadInicial { get; set; } = null!;
        public bool Auditable { get; set; }
        public bool EnviarAcola { get; set; }

        public virtual ICollection<Comando2> Comando2s { get; set; }
        public virtual ICollection<SubActividad> SubActividads { get; set; }
    }
}
