using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SubActividadSiguiente
    {
        public string Pkid { get; set; } = null!;
        public string IdsubActividad { get; set; } = null!;
        public string ValorNavegacion { get; set; } = null!;
        public string NombreSubActividadNavegacion { get; set; } = null!;

        public virtual SubActividad IdsubActividadNavigation { get; set; } = null!;
    }
}
