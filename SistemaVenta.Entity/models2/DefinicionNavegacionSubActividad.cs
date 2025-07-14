using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionNavegacionSubActividad
    {
        public string Pkid { get; set; } = null!;
        public string IddefinicionSubActividad { get; set; } = null!;
        public string ValorNavegacion { get; set; } = null!;

        public virtual DefinicionSubActividad IddefinicionSubActividadNavigation { get; set; } = null!;
    }
}
