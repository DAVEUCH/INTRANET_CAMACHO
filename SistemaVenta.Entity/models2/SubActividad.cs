using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SubActividad
    {
        public SubActividad()
        {
            ParametroSubActividads = new HashSet<ParametroSubActividad>();
            SubActividadSiguientes = new HashSet<SubActividadSiguiente>();
        }

        public string Pkid { get; set; } = null!;
        public string Idactividad { get; set; } = null!;
        public string IddefinicionSubActividad { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string RutaEstado { get; set; } = null!;

        public virtual Actividad IdactividadNavigation { get; set; } = null!;
        public virtual DefinicionSubActividad IddefinicionSubActividadNavigation { get; set; } = null!;
        public virtual ICollection<ParametroSubActividad> ParametroSubActividads { get; set; }
        public virtual ICollection<SubActividadSiguiente> SubActividadSiguientes { get; set; }
    }
}
